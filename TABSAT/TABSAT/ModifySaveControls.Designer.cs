﻿namespace TABSAT
{
    partial class ModifySaveControls
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.extractGroupBox = new System.Windows.Forms.GroupBox();
            this.extractManualRadioButton = new System.Windows.Forms.RadioButton();
            this.extractLeaveRadioButton = new System.Windows.Forms.RadioButton();
            this.extractTidyRadioButton = new System.Windows.Forms.RadioButton();
            this.manualGroupBox = new System.Windows.Forms.GroupBox();
            this.skipRepackButton = new System.Windows.Forms.Button();
            this.repackSaveButton = new System.Windows.Forms.Button();
            this.extractSaveButton = new System.Windows.Forms.Button();
            this.saveFileGroupBox = new System.Windows.Forms.GroupBox();
            this.saveFileTextBox = new System.Windows.Forms.TextBox();
            this.saveFileChooseButton = new System.Windows.Forms.Button();
            this.backupCheckBox = new System.Windows.Forms.CheckBox();
            this.modifyGroupBox = new System.Windows.Forms.GroupBox();
            this.modifySaveButton = new System.Windows.Forms.Button();
            this.fogGroupBox = new System.Windows.Forms.GroupBox();
            this.fogFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.leaveFogRadioButton = new System.Windows.Forms.RadioButton();
            this.removeFogRadioButton = new System.Windows.Forms.RadioButton();
            this.showFullRadioButton = new System.Windows.Forms.RadioButton();
            this.reduceFogPanel = new System.Windows.Forms.Panel();
            this.fogNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.reduceFogRadioButton = new System.Windows.Forms.RadioButton();
            this.mutantGroupBox = new System.Windows.Forms.GroupBox();
            this.mutantsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mutantsNothingRadio = new System.Windows.Forms.RadioButton();
            this.mutantsRemoveRadio = new System.Windows.Forms.RadioButton();
            this.replaceAllPanel = new System.Windows.Forms.Panel();
            this.mutantReplaceAllRadio = new System.Windows.Forms.RadioButton();
            this.mutantReplaceAllComboBox = new System.Windows.Forms.ComboBox();
            this.mutantsMovePanel = new System.Windows.Forms.Panel();
            this.mutantMoveCCLabel = new System.Windows.Forms.Label();
            this.mutantMoveGlobalComboBox = new System.Windows.Forms.ComboBox();
            this.mutantMoveWhatComboBox = new System.Windows.Forms.ComboBox();
            this.mutantsMoveRadio = new System.Windows.Forms.RadioButton();
            this.reflectorGroupBox = new System.Windows.Forms.GroupBox();
            this.reflectorExtractRadioButton = new System.Windows.Forms.RadioButton();
            this.reflectorRepackRadioButton = new System.Windows.Forms.RadioButton();
            this.reflectorExitRadioButton = new System.Windows.Forms.RadioButton();
            this.processGroupBox = new System.Windows.Forms.GroupBox();
            this.reflectorTextBox = new System.Windows.Forms.TextBox();
            this.modifyHintLabel = new System.Windows.Forms.Label();
            this.themeGroupBox = new System.Windows.Forms.GroupBox();
            this.themeCheckBox = new System.Windows.Forms.CheckBox();
            this.themeComboBox = new System.Windows.Forms.ComboBox();
            this.saveOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.processFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.extractGroupBox.SuspendLayout();
            this.manualGroupBox.SuspendLayout();
            this.saveFileGroupBox.SuspendLayout();
            this.modifyGroupBox.SuspendLayout();
            this.fogGroupBox.SuspendLayout();
            this.fogFlowLayoutPanel.SuspendLayout();
            this.reduceFogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fogNumericUpDown)).BeginInit();
            this.mutantGroupBox.SuspendLayout();
            this.mutantsFlowLayoutPanel.SuspendLayout();
            this.replaceAllPanel.SuspendLayout();
            this.mutantsMovePanel.SuspendLayout();
            this.reflectorGroupBox.SuspendLayout();
            this.processGroupBox.SuspendLayout();
            this.themeGroupBox.SuspendLayout();
            this.dataFlowLayoutPanel.SuspendLayout();
            this.processFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // extractGroupBox
            // 
            this.extractGroupBox.Controls.Add(this.extractManualRadioButton);
            this.extractGroupBox.Controls.Add(this.extractLeaveRadioButton);
            this.extractGroupBox.Controls.Add(this.extractTidyRadioButton);
            this.extractGroupBox.Location = new System.Drawing.Point(161, 3);
            this.extractGroupBox.Name = "extractGroupBox";
            this.extractGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.extractGroupBox.Size = new System.Drawing.Size(132, 100);
            this.extractGroupBox.TabIndex = 4;
            this.extractGroupBox.TabStop = false;
            this.extractGroupBox.Text = "Extracted Files";
            // 
            // extractManualRadioButton
            // 
            this.extractManualRadioButton.AutoSize = true;
            this.extractManualRadioButton.Location = new System.Drawing.Point(6, 65);
            this.extractManualRadioButton.Name = "extractManualRadioButton";
            this.extractManualRadioButton.Size = new System.Drawing.Size(125, 17);
            this.extractManualRadioButton.TabIndex = 2;
            this.extractManualRadioButton.Text = "Manual Editing Mode";
            this.extractManualRadioButton.UseVisualStyleBackColor = true;
            this.extractManualRadioButton.CheckedChanged += new System.EventHandler(this.extractRadioButtons_CheckedChanged);
            // 
            // extractLeaveRadioButton
            // 
            this.extractLeaveRadioButton.AutoSize = true;
            this.extractLeaveRadioButton.Location = new System.Drawing.Point(6, 42);
            this.extractLeaveRadioButton.Name = "extractLeaveRadioButton";
            this.extractLeaveRadioButton.Size = new System.Drawing.Size(55, 17);
            this.extractLeaveRadioButton.TabIndex = 1;
            this.extractLeaveRadioButton.Text = "Leave";
            this.extractLeaveRadioButton.UseVisualStyleBackColor = true;
            this.extractLeaveRadioButton.CheckedChanged += new System.EventHandler(this.extractRadioButtons_CheckedChanged);
            // 
            // extractTidyRadioButton
            // 
            this.extractTidyRadioButton.AutoSize = true;
            this.extractTidyRadioButton.Checked = true;
            this.extractTidyRadioButton.Location = new System.Drawing.Point(6, 19);
            this.extractTidyRadioButton.Name = "extractTidyRadioButton";
            this.extractTidyRadioButton.Size = new System.Drawing.Size(74, 17);
            this.extractTidyRadioButton.TabIndex = 0;
            this.extractTidyRadioButton.TabStop = true;
            this.extractTidyRadioButton.Text = "Tidy Away";
            this.extractTidyRadioButton.UseVisualStyleBackColor = true;
            this.extractTidyRadioButton.CheckedChanged += new System.EventHandler(this.extractRadioButtons_CheckedChanged);
            // 
            // manualGroupBox
            // 
            this.manualGroupBox.Controls.Add(this.skipRepackButton);
            this.manualGroupBox.Controls.Add(this.repackSaveButton);
            this.manualGroupBox.Controls.Add(this.extractSaveButton);
            this.manualGroupBox.Enabled = false;
            this.manualGroupBox.Location = new System.Drawing.Point(299, 3);
            this.manualGroupBox.Name = "manualGroupBox";
            this.manualGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.manualGroupBox.Size = new System.Drawing.Size(132, 130);
            this.manualGroupBox.TabIndex = 5;
            this.manualGroupBox.TabStop = false;
            this.manualGroupBox.Text = "Manual Editing Mode";
            // 
            // skipRepackButton
            // 
            this.skipRepackButton.Enabled = false;
            this.skipRepackButton.Location = new System.Drawing.Point(6, 91);
            this.skipRepackButton.Name = "skipRepackButton";
            this.skipRepackButton.Size = new System.Drawing.Size(120, 30);
            this.skipRepackButton.TabIndex = 2;
            this.skipRepackButton.Text = "Skip Repacking";
            this.skipRepackButton.UseVisualStyleBackColor = true;
            this.skipRepackButton.Click += new System.EventHandler(this.skipRepackButton_Click);
            // 
            // repackSaveButton
            // 
            this.repackSaveButton.Enabled = false;
            this.repackSaveButton.Location = new System.Drawing.Point(6, 55);
            this.repackSaveButton.Name = "repackSaveButton";
            this.repackSaveButton.Size = new System.Drawing.Size(120, 30);
            this.repackSaveButton.TabIndex = 1;
            this.repackSaveButton.Text = "Repack the Save File";
            this.repackSaveButton.UseVisualStyleBackColor = true;
            this.repackSaveButton.Click += new System.EventHandler(this.repackSaveButton_Click);
            // 
            // extractSaveButton
            // 
            this.extractSaveButton.Enabled = false;
            this.extractSaveButton.Location = new System.Drawing.Point(6, 19);
            this.extractSaveButton.Name = "extractSaveButton";
            this.extractSaveButton.Size = new System.Drawing.Size(120, 30);
            this.extractSaveButton.TabIndex = 0;
            this.extractSaveButton.Text = "Extract the Save File";
            this.extractSaveButton.UseVisualStyleBackColor = true;
            this.extractSaveButton.Click += new System.EventHandler(this.extractSaveButton_Click);
            // 
            // saveFileGroupBox
            // 
            this.saveFileGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFileGroupBox.Controls.Add(this.saveFileTextBox);
            this.saveFileGroupBox.Controls.Add(this.saveFileChooseButton);
            this.saveFileGroupBox.Controls.Add(this.backupCheckBox);
            this.saveFileGroupBox.Location = new System.Drawing.Point(6, 274);
            this.saveFileGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.saveFileGroupBox.MinimumSize = new System.Drawing.Size(0, 60);
            this.saveFileGroupBox.Name = "saveFileGroupBox";
            this.saveFileGroupBox.Size = new System.Drawing.Size(498, 60);
            this.saveFileGroupBox.TabIndex = 3;
            this.saveFileGroupBox.TabStop = false;
            this.saveFileGroupBox.Text = "Save File";
            // 
            // saveFileTextBox
            // 
            this.saveFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFileTextBox.Location = new System.Drawing.Point(114, 23);
            this.saveFileTextBox.Name = "saveFileTextBox";
            this.saveFileTextBox.ReadOnly = true;
            this.saveFileTextBox.Size = new System.Drawing.Size(252, 20);
            this.saveFileTextBox.TabIndex = 1;
            this.saveFileTextBox.WordWrap = false;
            // 
            // saveFileChooseButton
            // 
            this.saveFileChooseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFileChooseButton.Location = new System.Drawing.Point(372, 17);
            this.saveFileChooseButton.Name = "saveFileChooseButton";
            this.saveFileChooseButton.Size = new System.Drawing.Size(120, 30);
            this.saveFileChooseButton.TabIndex = 2;
            this.saveFileChooseButton.Text = "Choose a Save File...";
            this.saveFileChooseButton.UseVisualStyleBackColor = true;
            this.saveFileChooseButton.Click += new System.EventHandler(this.saveFileChooseButton_Click);
            // 
            // backupCheckBox
            // 
            this.backupCheckBox.AutoSize = true;
            this.backupCheckBox.Checked = true;
            this.backupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backupCheckBox.Location = new System.Drawing.Point(9, 25);
            this.backupCheckBox.Name = "backupCheckBox";
            this.backupCheckBox.Size = new System.Drawing.Size(99, 17);
            this.backupCheckBox.TabIndex = 0;
            this.backupCheckBox.Text = "Backup original";
            this.backupCheckBox.UseVisualStyleBackColor = true;
            // 
            // modifyGroupBox
            // 
            this.modifyGroupBox.Controls.Add(this.modifySaveButton);
            this.modifyGroupBox.Location = new System.Drawing.Point(437, 3);
            this.modifyGroupBox.Name = "modifyGroupBox";
            this.modifyGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.modifyGroupBox.Size = new System.Drawing.Size(132, 60);
            this.modifyGroupBox.TabIndex = 6;
            this.modifyGroupBox.TabStop = false;
            this.modifyGroupBox.Text = "Quick Mode";
            // 
            // modifySaveButton
            // 
            this.modifySaveButton.Location = new System.Drawing.Point(6, 19);
            this.modifySaveButton.Name = "modifySaveButton";
            this.modifySaveButton.Size = new System.Drawing.Size(120, 30);
            this.modifySaveButton.TabIndex = 0;
            this.modifySaveButton.Text = "Modify the Save File";
            this.modifySaveButton.UseVisualStyleBackColor = true;
            this.modifySaveButton.Click += new System.EventHandler(this.modifySaveButton_Click);
            // 
            // fogGroupBox
            // 
            this.fogGroupBox.Controls.Add(this.fogFlowLayoutPanel);
            this.fogGroupBox.Location = new System.Drawing.Point(3, 134);
            this.fogGroupBox.Name = "fogGroupBox";
            this.fogGroupBox.Size = new System.Drawing.Size(252, 125);
            this.fogGroupBox.TabIndex = 2;
            this.fogGroupBox.TabStop = false;
            this.fogGroupBox.Text = "Fog of War";
            // 
            // fogFlowLayoutPanel
            // 
            this.fogFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fogFlowLayoutPanel.Controls.Add(this.leaveFogRadioButton);
            this.fogFlowLayoutPanel.Controls.Add(this.removeFogRadioButton);
            this.fogFlowLayoutPanel.Controls.Add(this.showFullRadioButton);
            this.fogFlowLayoutPanel.Controls.Add(this.reduceFogPanel);
            this.fogFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fogFlowLayoutPanel.Location = new System.Drawing.Point(6, 18);
            this.fogFlowLayoutPanel.Name = "fogFlowLayoutPanel";
            this.fogFlowLayoutPanel.Size = new System.Drawing.Size(240, 101);
            this.fogFlowLayoutPanel.TabIndex = 15;
            // 
            // leaveFogRadioButton
            // 
            this.leaveFogRadioButton.AutoSize = true;
            this.leaveFogRadioButton.Checked = true;
            this.leaveFogRadioButton.Location = new System.Drawing.Point(3, 3);
            this.leaveFogRadioButton.Name = "leaveFogRadioButton";
            this.leaveFogRadioButton.Size = new System.Drawing.Size(90, 17);
            this.leaveFogRadioButton.TabIndex = 0;
            this.leaveFogRadioButton.TabStop = true;
            this.leaveFogRadioButton.Text = "Do not modify";
            this.leaveFogRadioButton.UseVisualStyleBackColor = true;
            // 
            // removeFogRadioButton
            // 
            this.removeFogRadioButton.AutoSize = true;
            this.removeFogRadioButton.Location = new System.Drawing.Point(3, 26);
            this.removeFogRadioButton.Name = "removeFogRadioButton";
            this.removeFogRadioButton.Size = new System.Drawing.Size(79, 17);
            this.removeFogRadioButton.TabIndex = 1;
            this.removeFogRadioButton.Text = "Remove All";
            this.removeFogRadioButton.UseVisualStyleBackColor = true;
            // 
            // showFullRadioButton
            // 
            this.showFullRadioButton.AutoSize = true;
            this.showFullRadioButton.Location = new System.Drawing.Point(3, 49);
            this.showFullRadioButton.Name = "showFullRadioButton";
            this.showFullRadioButton.Size = new System.Drawing.Size(125, 17);
            this.showFullRadioButton.TabIndex = 3;
            this.showFullRadioButton.Text = "Grant Full Map Vision";
            this.showFullRadioButton.UseVisualStyleBackColor = true;
            // 
            // reduceFogPanel
            // 
            this.reduceFogPanel.Controls.Add(this.fogNumericUpDown);
            this.reduceFogPanel.Controls.Add(this.reduceFogRadioButton);
            this.reduceFogPanel.Location = new System.Drawing.Point(3, 72);
            this.reduceFogPanel.MinimumSize = new System.Drawing.Size(225, 20);
            this.reduceFogPanel.Name = "reduceFogPanel";
            this.reduceFogPanel.Size = new System.Drawing.Size(225, 21);
            this.reduceFogPanel.TabIndex = 14;
            // 
            // fogNumericUpDown
            // 
            this.fogNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fogNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fogNumericUpDown.Location = new System.Drawing.Point(190, 1);
            this.fogNumericUpDown.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.fogNumericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.fogNumericUpDown.Name = "fogNumericUpDown";
            this.fogNumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.fogNumericUpDown.TabIndex = 13;
            this.fogNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.fogNumericUpDown.ValueChanged += new System.EventHandler(this.fogNumericUpDown_ValueChanged);
            // 
            // reduceFogRadioButton
            // 
            this.reduceFogRadioButton.AutoSize = true;
            this.reduceFogRadioButton.Location = new System.Drawing.Point(0, 0);
            this.reduceFogRadioButton.Name = "reduceFogRadioButton";
            this.reduceFogRadioButton.Size = new System.Drawing.Size(194, 17);
            this.reduceFogRadioButton.TabIndex = 2;
            this.reduceFogRadioButton.Text = "Clear a circle around the CC, radius:";
            this.reduceFogRadioButton.UseVisualStyleBackColor = true;
            // 
            // mutantGroupBox
            // 
            this.mutantGroupBox.Controls.Add(this.mutantsFlowLayoutPanel);
            this.mutantGroupBox.Location = new System.Drawing.Point(3, 3);
            this.mutantGroupBox.Name = "mutantGroupBox";
            this.mutantGroupBox.Size = new System.Drawing.Size(365, 125);
            this.mutantGroupBox.TabIndex = 1;
            this.mutantGroupBox.TabStop = false;
            this.mutantGroupBox.Text = "Mutants";
            // 
            // mutantsFlowLayoutPanel
            // 
            this.mutantsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mutantsFlowLayoutPanel.Controls.Add(this.mutantsNothingRadio);
            this.mutantsFlowLayoutPanel.Controls.Add(this.mutantsRemoveRadio);
            this.mutantsFlowLayoutPanel.Controls.Add(this.replaceAllPanel);
            this.mutantsFlowLayoutPanel.Controls.Add(this.mutantsMovePanel);
            this.mutantsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mutantsFlowLayoutPanel.Location = new System.Drawing.Point(6, 18);
            this.mutantsFlowLayoutPanel.Name = "mutantsFlowLayoutPanel";
            this.mutantsFlowLayoutPanel.Size = new System.Drawing.Size(353, 101);
            this.mutantsFlowLayoutPanel.TabIndex = 7;
            // 
            // mutantsNothingRadio
            // 
            this.mutantsNothingRadio.AutoSize = true;
            this.mutantsNothingRadio.Checked = true;
            this.mutantsNothingRadio.Location = new System.Drawing.Point(3, 3);
            this.mutantsNothingRadio.Name = "mutantsNothingRadio";
            this.mutantsNothingRadio.Size = new System.Drawing.Size(90, 17);
            this.mutantsNothingRadio.TabIndex = 0;
            this.mutantsNothingRadio.TabStop = true;
            this.mutantsNothingRadio.Text = "Do not modify";
            this.mutantsNothingRadio.UseVisualStyleBackColor = true;
            this.mutantsNothingRadio.CheckedChanged += new System.EventHandler(this.mutantsSimpleRadio_CheckedChanged);
            // 
            // mutantsRemoveRadio
            // 
            this.mutantsRemoveRadio.AutoSize = true;
            this.mutantsRemoveRadio.Location = new System.Drawing.Point(3, 26);
            this.mutantsRemoveRadio.Name = "mutantsRemoveRadio";
            this.mutantsRemoveRadio.Size = new System.Drawing.Size(79, 17);
            this.mutantsRemoveRadio.TabIndex = 1;
            this.mutantsRemoveRadio.Text = "Remove All";
            this.mutantsRemoveRadio.UseVisualStyleBackColor = true;
            this.mutantsRemoveRadio.CheckedChanged += new System.EventHandler(this.mutantsSimpleRadio_CheckedChanged);
            // 
            // replaceAllPanel
            // 
            this.replaceAllPanel.Controls.Add(this.mutantReplaceAllRadio);
            this.replaceAllPanel.Controls.Add(this.mutantReplaceAllComboBox);
            this.replaceAllPanel.Enabled = false;
            this.replaceAllPanel.Location = new System.Drawing.Point(3, 49);
            this.replaceAllPanel.Name = "replaceAllPanel";
            this.replaceAllPanel.Size = new System.Drawing.Size(206, 21);
            this.replaceAllPanel.TabIndex = 9;
            // 
            // mutantReplaceAllRadio
            // 
            this.mutantReplaceAllRadio.AutoSize = true;
            this.mutantReplaceAllRadio.Location = new System.Drawing.Point(0, 1);
            this.mutantReplaceAllRadio.Name = "mutantReplaceAllRadio";
            this.mutantReplaceAllRadio.Size = new System.Drawing.Size(79, 17);
            this.mutantReplaceAllRadio.TabIndex = 7;
            this.mutantReplaceAllRadio.TabStop = true;
            this.mutantReplaceAllRadio.Text = "Replace All";
            this.mutantReplaceAllRadio.UseVisualStyleBackColor = true;
            this.mutantReplaceAllRadio.CheckedChanged += new System.EventHandler(this.mutantReplaceAllRadio_CheckedChanged);
            // 
            // mutantReplaceAllComboBox
            // 
            this.mutantReplaceAllComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mutantReplaceAllComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mutantReplaceAllComboBox.FormattingEnabled = true;
            this.mutantReplaceAllComboBox.Items.AddRange(new object[] {
            "Mutants with Giants",
            "Giants with Mutants"});
            this.mutantReplaceAllComboBox.Location = new System.Drawing.Point(79, -1);
            this.mutantReplaceAllComboBox.Name = "mutantReplaceAllComboBox";
            this.mutantReplaceAllComboBox.Size = new System.Drawing.Size(124, 21);
            this.mutantReplaceAllComboBox.TabIndex = 8;
            // 
            // mutantsMovePanel
            // 
            this.mutantsMovePanel.Controls.Add(this.mutantMoveCCLabel);
            this.mutantsMovePanel.Controls.Add(this.mutantMoveGlobalComboBox);
            this.mutantsMovePanel.Controls.Add(this.mutantMoveWhatComboBox);
            this.mutantsMovePanel.Controls.Add(this.mutantsMoveRadio);
            this.mutantsMovePanel.Location = new System.Drawing.Point(3, 76);
            this.mutantsMovePanel.MinimumSize = new System.Drawing.Size(340, 20);
            this.mutantsMovePanel.Name = "mutantsMovePanel";
            this.mutantsMovePanel.Size = new System.Drawing.Size(340, 20);
            this.mutantsMovePanel.TabIndex = 6;
            // 
            // mutantMoveCCLabel
            // 
            this.mutantMoveCCLabel.AutoSize = true;
            this.mutantMoveCCLabel.Location = new System.Drawing.Point(162, 1);
            this.mutantMoveCCLabel.Name = "mutantMoveCCLabel";
            this.mutantMoveCCLabel.Size = new System.Drawing.Size(44, 13);
            this.mutantMoveCCLabel.TabIndex = 5;
            this.mutantMoveCCLabel.Text = "from CC";
            // 
            // mutantMoveGlobalComboBox
            // 
            this.mutantMoveGlobalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mutantMoveGlobalComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mutantMoveGlobalComboBox.FormattingEnabled = true;
            this.mutantMoveGlobalComboBox.Items.AddRange(new object[] {
            "anywhere on the map",
            "per compass quadrant"});
            this.mutantMoveGlobalComboBox.Location = new System.Drawing.Point(205, -3);
            this.mutantMoveGlobalComboBox.Name = "mutantMoveGlobalComboBox";
            this.mutantMoveGlobalComboBox.Size = new System.Drawing.Size(131, 21);
            this.mutantMoveGlobalComboBox.TabIndex = 4;
            // 
            // mutantMoveWhatComboBox
            // 
            this.mutantMoveWhatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mutantMoveWhatComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mutantMoveWhatComboBox.FormattingEnabled = true;
            this.mutantMoveWhatComboBox.Items.AddRange(new object[] {
            "Giant",
            "Mutant"});
            this.mutantMoveWhatComboBox.Location = new System.Drawing.Point(99, -3);
            this.mutantMoveWhatComboBox.Name = "mutantMoveWhatComboBox";
            this.mutantMoveWhatComboBox.Size = new System.Drawing.Size(57, 21);
            this.mutantMoveWhatComboBox.TabIndex = 3;
            // 
            // mutantsMoveRadio
            // 
            this.mutantsMoveRadio.AutoSize = true;
            this.mutantsMoveRadio.Location = new System.Drawing.Point(0, -1);
            this.mutantsMoveRadio.Name = "mutantsMoveRadio";
            this.mutantsMoveRadio.Size = new System.Drawing.Size(102, 17);
            this.mutantsMoveRadio.TabIndex = 2;
            this.mutantsMoveRadio.Text = "Move to farthest";
            this.mutantsMoveRadio.UseVisualStyleBackColor = true;
            this.mutantsMoveRadio.CheckedChanged += new System.EventHandler(this.mutantsMoveRadio_CheckedChanged);
            // 
            // reflectorGroupBox
            // 
            this.reflectorGroupBox.Controls.Add(this.reflectorExtractRadioButton);
            this.reflectorGroupBox.Controls.Add(this.reflectorRepackRadioButton);
            this.reflectorGroupBox.Controls.Add(this.reflectorExitRadioButton);
            this.reflectorGroupBox.Location = new System.Drawing.Point(3, 3);
            this.reflectorGroupBox.Name = "reflectorGroupBox";
            this.reflectorGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reflectorGroupBox.Size = new System.Drawing.Size(152, 100);
            this.reflectorGroupBox.TabIndex = 7;
            this.reflectorGroupBox.TabStop = false;
            this.reflectorGroupBox.Text = "Reflector Stops:";
            // 
            // reflectorExtractRadioButton
            // 
            this.reflectorExtractRadioButton.AutoSize = true;
            this.reflectorExtractRadioButton.Enabled = false;
            this.reflectorExtractRadioButton.Location = new System.Drawing.Point(6, 65);
            this.reflectorExtractRadioButton.Name = "reflectorExtractRadioButton";
            this.reflectorExtractRadioButton.Size = new System.Drawing.Size(143, 17);
            this.reflectorExtractRadioButton.TabIndex = 2;
            this.reflectorExtractRadioButton.Text = "After extracting Save File";
            this.reflectorExtractRadioButton.UseVisualStyleBackColor = true;
            // 
            // reflectorRepackRadioButton
            // 
            this.reflectorRepackRadioButton.AutoSize = true;
            this.reflectorRepackRadioButton.Checked = true;
            this.reflectorRepackRadioButton.Location = new System.Drawing.Point(6, 42);
            this.reflectorRepackRadioButton.Name = "reflectorRepackRadioButton";
            this.reflectorRepackRadioButton.Size = new System.Drawing.Size(144, 17);
            this.reflectorRepackRadioButton.TabIndex = 1;
            this.reflectorRepackRadioButton.TabStop = true;
            this.reflectorRepackRadioButton.Text = "After repacking Save File";
            this.reflectorRepackRadioButton.UseVisualStyleBackColor = true;
            // 
            // reflectorExitRadioButton
            // 
            this.reflectorExitRadioButton.AutoSize = true;
            this.reflectorExitRadioButton.Location = new System.Drawing.Point(6, 19);
            this.reflectorExitRadioButton.Name = "reflectorExitRadioButton";
            this.reflectorExitRadioButton.Size = new System.Drawing.Size(104, 17);
            this.reflectorExitRadioButton.TabIndex = 0;
            this.reflectorExitRadioButton.Text = "On TABSAT Exit";
            this.reflectorExitRadioButton.UseVisualStyleBackColor = true;
            // 
            // processGroupBox
            // 
            this.processGroupBox.Controls.Add(this.reflectorTextBox);
            this.processGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processGroupBox.Location = new System.Drawing.Point(6, 533);
            this.processGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.processGroupBox.MinimumSize = new System.Drawing.Size(200, 60);
            this.processGroupBox.Name = "processGroupBox";
            this.processGroupBox.Size = new System.Drawing.Size(498, 131);
            this.processGroupBox.TabIndex = 29;
            this.processGroupBox.TabStop = false;
            this.processGroupBox.Text = "Reflector process output";
            // 
            // reflectorTextBox
            // 
            this.reflectorTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reflectorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reflectorTextBox.Location = new System.Drawing.Point(3, 16);
            this.reflectorTextBox.Multiline = true;
            this.reflectorTextBox.Name = "reflectorTextBox";
            this.reflectorTextBox.ReadOnly = true;
            this.reflectorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.reflectorTextBox.Size = new System.Drawing.Size(492, 112);
            this.reflectorTextBox.TabIndex = 0;
            this.reflectorTextBox.WordWrap = false;
            // 
            // modifyHintLabel
            // 
            this.modifyHintLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyHintLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modifyHintLabel.Location = new System.Drawing.Point(6, 2);
            this.modifyHintLabel.Name = "modifyHintLabel";
            this.modifyHintLabel.Size = new System.Drawing.Size(497, 35);
            this.modifyHintLabel.TabIndex = 36;
            this.modifyHintLabel.Text = "1) Choose which Modifications to make.   2) Choose which Save File to modify.   3" +
    ") Start the Process.";
            this.modifyHintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // themeGroupBox
            // 
            this.themeGroupBox.Controls.Add(this.themeCheckBox);
            this.themeGroupBox.Controls.Add(this.themeComboBox);
            this.dataFlowLayoutPanel.SetFlowBreak(this.themeGroupBox, true);
            this.themeGroupBox.Location = new System.Drawing.Point(261, 134);
            this.themeGroupBox.Name = "themeGroupBox";
            this.themeGroupBox.Size = new System.Drawing.Size(213, 43);
            this.themeGroupBox.TabIndex = 35;
            this.themeGroupBox.TabStop = false;
            this.themeGroupBox.Text = "Theme";
            // 
            // themeCheckBox
            // 
            this.themeCheckBox.AutoSize = true;
            this.themeCheckBox.Location = new System.Drawing.Point(11, 19);
            this.themeCheckBox.Name = "themeCheckBox";
            this.themeCheckBox.Size = new System.Drawing.Size(78, 17);
            this.themeCheckBox.TabIndex = 0;
            this.themeCheckBox.Text = "Change to:";
            this.themeCheckBox.UseVisualStyleBackColor = true;
            // 
            // themeComboBox
            // 
            this.themeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeComboBox.FormattingEnabled = true;
            this.themeComboBox.Location = new System.Drawing.Point(87, 15);
            this.themeComboBox.Name = "themeComboBox";
            this.themeComboBox.Size = new System.Drawing.Size(116, 21);
            this.themeComboBox.TabIndex = 1;
            // 
            // dataFlowLayoutPanel
            // 
            this.dataFlowLayoutPanel.AutoScroll = true;
            this.dataFlowLayoutPanel.Controls.Add(this.mutantGroupBox);
            this.dataFlowLayoutPanel.Controls.Add(this.fogGroupBox);
            this.dataFlowLayoutPanel.Controls.Add(this.themeGroupBox);
            this.dataFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFlowLayoutPanel.Location = new System.Drawing.Point(3, 43);
            this.dataFlowLayoutPanel.Name = "dataFlowLayoutPanel";
            this.dataFlowLayoutPanel.Size = new System.Drawing.Size(504, 222);
            this.dataFlowLayoutPanel.TabIndex = 3;
            // 
            // processFlowLayoutPanel
            // 
            this.processFlowLayoutPanel.AutoScroll = true;
            this.processFlowLayoutPanel.Controls.Add(this.modifyGroupBox);
            this.processFlowLayoutPanel.Controls.Add(this.manualGroupBox);
            this.processFlowLayoutPanel.Controls.Add(this.extractGroupBox);
            this.processFlowLayoutPanel.Controls.Add(this.reflectorGroupBox);
            this.processFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.processFlowLayoutPanel.Location = new System.Drawing.Point(3, 331);
            this.processFlowLayoutPanel.Name = "processFlowLayoutPanel";
            this.processFlowLayoutPanel.Size = new System.Drawing.Size(504, 193);
            this.processFlowLayoutPanel.TabIndex = 37;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoScroll = true;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.saveFileGroupBox, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.processGroupBox, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.processFlowLayoutPanel, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.dataFlowLayoutPanel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.modifyHintLabel, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(510, 670);
            this.tableLayoutPanel.TabIndex = 38;
            // 
            // ModifySaveControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(506, 0);
            this.Name = "ModifySaveControls";
            this.Size = new System.Drawing.Size(510, 670);
            this.extractGroupBox.ResumeLayout(false);
            this.extractGroupBox.PerformLayout();
            this.manualGroupBox.ResumeLayout(false);
            this.saveFileGroupBox.ResumeLayout(false);
            this.saveFileGroupBox.PerformLayout();
            this.modifyGroupBox.ResumeLayout(false);
            this.fogGroupBox.ResumeLayout(false);
            this.fogFlowLayoutPanel.ResumeLayout(false);
            this.fogFlowLayoutPanel.PerformLayout();
            this.reduceFogPanel.ResumeLayout(false);
            this.reduceFogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fogNumericUpDown)).EndInit();
            this.mutantGroupBox.ResumeLayout(false);
            this.mutantsFlowLayoutPanel.ResumeLayout(false);
            this.mutantsFlowLayoutPanel.PerformLayout();
            this.replaceAllPanel.ResumeLayout(false);
            this.replaceAllPanel.PerformLayout();
            this.mutantsMovePanel.ResumeLayout(false);
            this.mutantsMovePanel.PerformLayout();
            this.reflectorGroupBox.ResumeLayout(false);
            this.reflectorGroupBox.PerformLayout();
            this.processGroupBox.ResumeLayout(false);
            this.processGroupBox.PerformLayout();
            this.themeGroupBox.ResumeLayout(false);
            this.themeGroupBox.PerformLayout();
            this.dataFlowLayoutPanel.ResumeLayout(false);
            this.processFlowLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox saveFileGroupBox;
        private System.Windows.Forms.TextBox saveFileTextBox;
        private System.Windows.Forms.Button saveFileChooseButton;
        private System.Windows.Forms.CheckBox backupCheckBox;
        private System.Windows.Forms.GroupBox reflectorGroupBox;
        private System.Windows.Forms.RadioButton reflectorExtractRadioButton;
        private System.Windows.Forms.RadioButton reflectorRepackRadioButton;
        private System.Windows.Forms.RadioButton reflectorExitRadioButton;
        private System.Windows.Forms.GroupBox processGroupBox;
        private System.Windows.Forms.TextBox reflectorTextBox;
        private System.Windows.Forms.GroupBox extractGroupBox;
        private System.Windows.Forms.RadioButton extractManualRadioButton;
        private System.Windows.Forms.RadioButton extractLeaveRadioButton;
        private System.Windows.Forms.RadioButton extractTidyRadioButton;
        private System.Windows.Forms.GroupBox manualGroupBox;
        private System.Windows.Forms.Button skipRepackButton;
        private System.Windows.Forms.Button repackSaveButton;
        private System.Windows.Forms.Button extractSaveButton;
        private System.Windows.Forms.GroupBox modifyGroupBox;
        private System.Windows.Forms.Button modifySaveButton;
        private System.Windows.Forms.GroupBox fogGroupBox;
        private System.Windows.Forms.FlowLayoutPanel fogFlowLayoutPanel;
        private System.Windows.Forms.RadioButton leaveFogRadioButton;
        private System.Windows.Forms.RadioButton removeFogRadioButton;
        private System.Windows.Forms.Panel reduceFogPanel;
        private System.Windows.Forms.NumericUpDown fogNumericUpDown;
        private System.Windows.Forms.RadioButton reduceFogRadioButton;
        private System.Windows.Forms.RadioButton showFullRadioButton;
        private System.Windows.Forms.GroupBox mutantGroupBox;
        private System.Windows.Forms.FlowLayoutPanel mutantsFlowLayoutPanel;
        private System.Windows.Forms.RadioButton mutantsNothingRadio;
        private System.Windows.Forms.RadioButton mutantsRemoveRadio;
        private System.Windows.Forms.Panel mutantsMovePanel;
        private System.Windows.Forms.Label mutantMoveCCLabel;
        private System.Windows.Forms.ComboBox mutantMoveGlobalComboBox;
        private System.Windows.Forms.ComboBox mutantMoveWhatComboBox;
        private System.Windows.Forms.RadioButton mutantsMoveRadio;
        private System.Windows.Forms.Label modifyHintLabel;
        private System.Windows.Forms.GroupBox themeGroupBox;
        private System.Windows.Forms.CheckBox themeCheckBox;
        private System.Windows.Forms.ComboBox themeComboBox;
        private System.Windows.Forms.OpenFileDialog saveOpenFileDialog;
        private System.Windows.Forms.RadioButton mutantReplaceAllRadio;
        private System.Windows.Forms.Panel replaceAllPanel;
        private System.Windows.Forms.ComboBox mutantReplaceAllComboBox;
        private System.Windows.Forms.FlowLayoutPanel dataFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel processFlowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
