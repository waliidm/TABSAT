﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TABSAT
{
    public class TAB
    {
        public const string EXE_NAME = "TheyAreBillions.exe";
        public const string SAVE_EXTENSION = ".zxsav";
        public const string CHECK_EXTENSION = ".zxcheck";
        public const string SAVES_FILTER = "*" + SAVE_EXTENSION;
        public const string CHECKS_FILTER = "*" + CHECK_EXTENSION;

        private const string STEAM_VDF_SUBPATH = @"config\config.vdf";
        //example string libraryLine =               @"    ""BaseInstallFolder_1""		         ""K:\\SteamLibrary""";
        private const string STEAM_LIBRARY_PATTERN = @"^\s+""BaseInstallFolder_(?<count>\d+)""\s+""(?<path>.+)""$";
        private const string STEAM_TAB_SUBPATH = @"\steamapps\common\They Are Billions\";

        public static readonly string DEFAULT_SAVES_DIRECTORY = Environment.ExpandEnvironmentVariables( @"%USERPROFILE%\Documents\My Games\They Are Billions\Saves\" );

        public static string GetExeDirectory()
        {
            string steamConfigPath = GetSteamConfig();
            if( steamConfigPath != null )
            {
                //Console.WriteLine( "Steam Libraries listed within: " + steamConfigPath );

                LinkedList<string> steamLibraries = GetSteamLibraries( steamConfigPath );

                foreach( string library in steamLibraries )
                {
                    string TABdirectory = library + STEAM_TAB_SUBPATH;
                    if( Directory.Exists( TABdirectory ) )
                    {
                        //Console.WriteLine( "Located TAB: " + TABdirectory );
                        return TABdirectory;
                    }
                }
            }
            return null;
        }

        private static string GetSteamConfig()
        {
            using( RegistryKey steamKey = Registry.CurrentUser.OpenSubKey( @"Software\Valve\Steam" ) )
            {
                if( steamKey != null )
                {
                    object SteamPathValue = steamKey.GetValue( "SteamPath" );
                    //Console.WriteLine( "Located Steam: " + SteamPathValue );
                    if( steamKey != null )
                    {
                        string steamConfigPath = Path.Combine( (string) SteamPathValue, STEAM_VDF_SUBPATH );
                        if( File.Exists( steamConfigPath ) )
                        {
                            return steamConfigPath;
                        }
                    }
                }
            }
            return null;
        }

        private static LinkedList<string> GetSteamLibraries( string steamConfigPath )
        {
            LinkedList<string> steamLibraries = new LinkedList<string>();

            Regex libraryRegex = new Regex( STEAM_LIBRARY_PATTERN, RegexOptions.Compiled );

            using( StreamReader config = new StreamReader( steamConfigPath ) )
            {
                string line;
                while( ( line = config.ReadLine() ) != null )
                {
                    Match match = libraryRegex.Match( line );
                    if( match.Success )
                    {
                        string libraryPath = match.Groups["path"].Value;
                        //Console.WriteLine( "SteamLibrary #" + match.Groups["count"].Value + ": " + libraryPath );
                        steamLibraries.AddFirst( libraryPath );
                    }
                }
            }

            return steamLibraries;
        }

        public static string GetMostRecentSave( string savesDir )
        {
            if( !Directory.Exists( savesDir ) )
            {
                throw new ArgumentException( "The provided saves directory does not exist." );
            }
            DirectoryInfo savesDirInfo = new DirectoryInfo( savesDir );
            FileInfo[] savesInfo = savesDirInfo.GetFiles( SAVES_FILTER );
            if( savesInfo.Length > 0 )
            {
                IOrderedEnumerable<FileInfo> sortedSavesInfo = savesInfo.OrderByDescending( s => s.CreationTimeUtc );
                FileInfo newestSave = sortedSavesInfo.First();
                return newestSave.FullName;
            }
            return null;
        }

        public static bool IsFileWithinDirectory( string file, string directory )
        {
            return Path.GetFullPath( file ).StartsWith( Path.GetFullPath( directory ) );
        }
    }
}