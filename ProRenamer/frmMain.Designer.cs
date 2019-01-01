namespace ProRenamer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddFile = new System.Windows.Forms.ToolStripButton();
            this.tsbAddFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeleteFile = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbFiles = new System.Windows.Forms.ToolStripButton();
            this.tsbAction = new System.Windows.Forms.ToolStripButton();
            this.tsbLog = new System.Windows.Forms.ToolStripButton();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.chFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFullPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExtention = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPreview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAudioLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAudioArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAudioTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlLog = new System.Windows.Forms.Panel();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.pnlActionInsert = new System.Windows.Forms.Panel();
            this.cbActionInsert = new System.Windows.Forms.ComboBox();
            this.rbActionInsertFromEnd = new System.Windows.Forms.RadioButton();
            this.rbActionInsertFromBegin = new System.Windows.Forms.RadioButton();
            this.nudActionInsertPosition = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.pnlActionExtension = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNewExtensionAppend = new System.Windows.Forms.CheckBox();
            this.tbActionExtension = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAction = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.pnlFiles.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlActionInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudActionInsertPosition)).BeginInit();
            this.pnlActionExtension.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Location = new System.Drawing.Point(0, 358);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.ssMain.Size = new System.Drawing.Size(600, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddFile,
            this.tsbAddFolder,
            this.toolStripSeparator1,
            this.tsbDeleteFile,
            this.tsbDeleteAll});
            this.toolStrip1.Location = new System.Drawing.Point(6, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(399, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddFile
            // 
            this.tsbAddFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddFile.Image")));
            this.tsbAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddFile.Name = "tsbAddFile";
            this.tsbAddFile.Size = new System.Drawing.Size(85, 24);
            this.tsbAddFile.Text = "Add file(s)";
            this.tsbAddFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbAddFile.ToolTipText = "Add file(s) (F2)";
            this.tsbAddFile.Click += new System.EventHandler(this.tsbAddFile_Click);
            // 
            // tsbAddFolder
            // 
            this.tsbAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddFolder.Image")));
            this.tsbAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddFolder.Name = "tsbAddFolder";
            this.tsbAddFolder.Size = new System.Drawing.Size(87, 24);
            this.tsbAddFolder.Text = "Add folder";
            this.tsbAddFolder.ToolTipText = "Add folder (F3)";
            this.tsbAddFolder.Click += new System.EventHandler(this.tsbAddFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbDeleteFile
            // 
            this.tsbDeleteFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteFile.Image")));
            this.tsbDeleteFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteFile.Name = "tsbDeleteFile";
            this.tsbDeleteFile.Size = new System.Drawing.Size(120, 24);
            this.tsbDeleteFile.Text = "Remove selected";
            this.tsbDeleteFile.ToolTipText = "Remove selected (F6)";
            this.tsbDeleteFile.Click += new System.EventHandler(this.tsbDeleteFile_Click);
            // 
            // tsbDeleteAll
            // 
            this.tsbDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteAll.Image")));
            this.tsbDeleteAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteAll.Name = "tsbDeleteAll";
            this.tsbDeleteAll.Size = new System.Drawing.Size(89, 24);
            this.tsbDeleteAll.Text = "Remove all";
            this.tsbDeleteAll.ToolTipText = "Remove all (F7)";
            this.tsbDeleteAll.Click += new System.EventHandler(this.tsbDeleteAll_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFiles,
            this.tsbAction,
            this.tsbLog});
            this.toolStrip2.Location = new System.Drawing.Point(6, 9);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(188, 27);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbFiles
            // 
            this.tsbFiles.Image = ((System.Drawing.Image)(resources.GetObject("tsbFiles.Image")));
            this.tsbFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiles.Name = "tsbFiles";
            this.tsbFiles.Size = new System.Drawing.Size(54, 24);
            this.tsbFiles.Text = "Files";
            this.tsbFiles.Click += new System.EventHandler(this.tsbFiles_Click);
            // 
            // tsbAction
            // 
            this.tsbAction.Image = ((System.Drawing.Image)(resources.GetObject("tsbAction.Image")));
            this.tsbAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAction.Name = "tsbAction";
            this.tsbAction.Size = new System.Drawing.Size(71, 24);
            this.tsbAction.Text = "Actions";
            this.tsbAction.Click += new System.EventHandler(this.tsbAction_Click);
            // 
            // tsbLog
            // 
            this.tsbLog.Image = ((System.Drawing.Image)(resources.GetObject("tsbLog.Image")));
            this.tsbLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLog.Name = "tsbLog";
            this.tsbLog.Size = new System.Drawing.Size(51, 24);
            this.tsbLog.Text = "Log";
            this.tsbLog.Click += new System.EventHandler(this.tsbLog_Click);
            // 
            // pnlFiles
            // 
            this.pnlFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiles.Controls.Add(this.lvFiles);
            this.pnlFiles.Location = new System.Drawing.Point(3, 68);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(594, 287);
            this.pnlFiles.TabIndex = 6;
            // 
            // lvFiles
            // 
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFolder,
            this.chFilename,
            this.chFullPath,
            this.chExtention,
            this.chPreview,
            this.chSize,
            this.chDateCreated,
            this.chDateModified,
            this.chAudioLength,
            this.chAudioArtist,
            this.chAudioTitle});
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFiles.Location = new System.Drawing.Point(0, 0);
            this.lvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(594, 287);
            this.lvFiles.TabIndex = 4;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            // 
            // chFolder
            // 
            this.chFolder.Text = "Folder";
            // 
            // chFilename
            // 
            this.chFilename.Text = "Filename";
            // 
            // chFullPath
            // 
            this.chFullPath.Text = "Full path";
            // 
            // chExtention
            // 
            this.chExtention.Text = "Ext.";
            // 
            // chPreview
            // 
            this.chPreview.Text = "Preview";
            // 
            // chSize
            // 
            this.chSize.Text = "Size";
            this.chSize.Width = 80;
            // 
            // chDateCreated
            // 
            this.chDateCreated.Text = "Date created";
            this.chDateCreated.Width = 100;
            // 
            // chDateModified
            // 
            this.chDateModified.Text = "Date modified";
            this.chDateModified.Width = 100;
            // 
            // chAudioLength
            // 
            this.chAudioLength.Text = "Audio Length";
            // 
            // chAudioArtist
            // 
            this.chAudioArtist.Text = "Audio Artist";
            // 
            // chAudioTitle
            // 
            this.chAudioTitle.Text = "Audio Title";
            // 
            // pnlLog
            // 
            this.pnlLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLog.Location = new System.Drawing.Point(3, 68);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(594, 287);
            this.pnlLog.TabIndex = 8;
            // 
            // pnlAction
            // 
            this.pnlAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAction.Controls.Add(this.pnlActionInsert);
            this.pnlAction.Controls.Add(this.btnPreview);
            this.pnlAction.Controls.Add(this.btnRun);
            this.pnlAction.Controls.Add(this.pnlActionExtension);
            this.pnlAction.Controls.Add(this.lbAction);
            this.pnlAction.Location = new System.Drawing.Point(3, 68);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(594, 287);
            this.pnlAction.TabIndex = 9;
            // 
            // pnlActionInsert
            // 
            this.pnlActionInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActionInsert.Controls.Add(this.cbActionInsert);
            this.pnlActionInsert.Controls.Add(this.rbActionInsertFromEnd);
            this.pnlActionInsert.Controls.Add(this.rbActionInsertFromBegin);
            this.pnlActionInsert.Controls.Add(this.nudActionInsertPosition);
            this.pnlActionInsert.Controls.Add(this.label5);
            this.pnlActionInsert.Controls.Add(this.label4);
            this.pnlActionInsert.Location = new System.Drawing.Point(157, 0);
            this.pnlActionInsert.Name = "pnlActionInsert";
            this.pnlActionInsert.Size = new System.Drawing.Size(437, 255);
            this.pnlActionInsert.TabIndex = 6;
            // 
            // cbActionInsert
            // 
            this.cbActionInsert.FormattingEnabled = true;
            this.cbActionInsert.Items.AddRange(new object[] {
            "Audio / Video Duration"});
            this.cbActionInsert.Location = new System.Drawing.Point(44, 22);
            this.cbActionInsert.Name = "cbActionInsert";
            this.cbActionInsert.Size = new System.Drawing.Size(150, 21);
            this.cbActionInsert.TabIndex = 7;
            // 
            // rbActionInsertFromEnd
            // 
            this.rbActionInsertFromEnd.AutoSize = true;
            this.rbActionInsertFromEnd.Location = new System.Drawing.Point(233, 65);
            this.rbActionInsertFromEnd.Name = "rbActionInsertFromEnd";
            this.rbActionInsertFromEnd.Size = new System.Drawing.Size(69, 17);
            this.rbActionInsertFromEnd.TabIndex = 6;
            this.rbActionInsertFromEnd.Text = "From end";
            this.rbActionInsertFromEnd.UseVisualStyleBackColor = true;
            // 
            // rbActionInsertFromBegin
            // 
            this.rbActionInsertFromBegin.AutoSize = true;
            this.rbActionInsertFromBegin.Checked = true;
            this.rbActionInsertFromBegin.Location = new System.Drawing.Point(150, 65);
            this.rbActionInsertFromBegin.Name = "rbActionInsertFromBegin";
            this.rbActionInsertFromBegin.Size = new System.Drawing.Size(77, 17);
            this.rbActionInsertFromBegin.TabIndex = 5;
            this.rbActionInsertFromBegin.TabStop = true;
            this.rbActionInsertFromBegin.Text = "From begin";
            this.rbActionInsertFromBegin.UseVisualStyleBackColor = true;
            // 
            // nudActionInsertPosition
            // 
            this.nudActionInsertPosition.Location = new System.Drawing.Point(44, 65);
            this.nudActionInsertPosition.Name = "nudActionInsertPosition";
            this.nudActionInsertPosition.Size = new System.Drawing.Size(100, 20);
            this.nudActionInsertPosition.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "After position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "String to insert";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(435, 261);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(516, 261);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // pnlActionExtension
            // 
            this.pnlActionExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActionExtension.Controls.Add(this.label3);
            this.pnlActionExtension.Controls.Add(this.label2);
            this.pnlActionExtension.Controls.Add(this.cbNewExtensionAppend);
            this.pnlActionExtension.Controls.Add(this.tbActionExtension);
            this.pnlActionExtension.Controls.Add(this.label1);
            this.pnlActionExtension.Location = new System.Drawing.Point(157, 0);
            this.pnlActionExtension.Name = "pnlActionExtension";
            this.pnlActionExtension.Size = new System.Drawing.Size(437, 255);
            this.pnlActionExtension.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Do not add the dot to begining of extension, it will be added by program";
            // 
            // cbNewExtensionAppend
            // 
            this.cbNewExtensionAppend.AutoSize = true;
            this.cbNewExtensionAppend.Location = new System.Drawing.Point(9, 48);
            this.cbNewExtensionAppend.Name = "cbNewExtensionAppend";
            this.cbNewExtensionAppend.Size = new System.Drawing.Size(252, 17);
            this.cbNewExtensionAppend.TabIndex = 2;
            this.cbNewExtensionAppend.Text = "Do not change extension, append it to full name";
            this.cbNewExtensionAppend.UseVisualStyleBackColor = true;
            // 
            // tbActionExtension
            // 
            this.tbActionExtension.Location = new System.Drawing.Point(44, 22);
            this.tbActionExtension.Name = "tbActionExtension";
            this.tbActionExtension.Size = new System.Drawing.Size(100, 20);
            this.tbActionExtension.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change extension with";
            // 
            // lbAction
            // 
            this.lbAction.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAction.FormattingEnabled = true;
            this.lbAction.Items.AddRange(new object[] {
            "Change extension",
            "Insert string"});
            this.lbAction.Location = new System.Drawing.Point(0, 0);
            this.lbAction.Name = "lbAction";
            this.lbAction.Size = new System.Drawing.Size(157, 287);
            this.lbAction.TabIndex = 0;
            this.lbAction.SelectedIndexChanged += new System.EventHandler(this.lbAction_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlFiles);
            this.Controls.Add(this.pnlLog);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "proGEDIA Renamer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.pnlFiles.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.pnlActionInsert.ResumeLayout(false);
            this.pnlActionInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudActionInsertPosition)).EndInit();
            this.pnlActionExtension.ResumeLayout(false);
            this.pnlActionExtension.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddFile;
        private System.Windows.Forms.ToolStripButton tsbAddFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDeleteFile;
        private System.Windows.Forms.ToolStripButton tsbDeleteAll;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbFiles;
        private System.Windows.Forms.ToolStripButton tsbAction;
        private System.Windows.Forms.ToolStripButton tsbLog;
        private System.Windows.Forms.Panel pnlFiles;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader chFolder;
        private System.Windows.Forms.ColumnHeader chFilename;
        private System.Windows.Forms.ColumnHeader chFullPath;
        private System.Windows.Forms.ColumnHeader chExtention;
        private System.Windows.Forms.ColumnHeader chPreview;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chDateCreated;
        private System.Windows.Forms.ColumnHeader chDateModified;
        private System.Windows.Forms.ColumnHeader chAudioLength;
        private System.Windows.Forms.ColumnHeader chAudioArtist;
        private System.Windows.Forms.ColumnHeader chAudioTitle;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.ListBox lbAction;
        private System.Windows.Forms.Panel pnlActionExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbActionExtension;
        private System.Windows.Forms.CheckBox cbNewExtensionAppend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel pnlActionInsert;
        private System.Windows.Forms.ComboBox cbActionInsert;
        private System.Windows.Forms.RadioButton rbActionInsertFromEnd;
        private System.Windows.Forms.RadioButton rbActionInsertFromBegin;
        private System.Windows.Forms.NumericUpDown nudActionInsertPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

