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
            this.lvFiles = new System.Windows.Forms.ListView();
            this.chFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFullPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExtention = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPreview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddFile = new System.Windows.Forms.ToolStripButton();
            this.tsbAddFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDeleteFile = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Location = new System.Drawing.Point(0, 446);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.ssMain.Size = new System.Drawing.Size(800, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // lvFiles
            // 
            this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFolder,
            this.chFilename,
            this.chFullPath,
            this.chExtention,
            this.chPreview,
            this.chSize,
            this.chDateCreated,
            this.chDateModified});
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFiles.Location = new System.Drawing.Point(10, 38);
            this.lvFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(778, 406);
            this.lvFiles.TabIndex = 3;
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
            this.toolStrip1.Location = new System.Drawing.Point(9, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(478, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddFile
            // 
            this.tsbAddFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddFile.Image")));
            this.tsbAddFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddFile.Name = "tsbAddFile";
            this.tsbAddFile.Size = new System.Drawing.Size(102, 24);
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
            this.tsbAddFolder.Size = new System.Drawing.Size(105, 24);
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
            this.tsbDeleteFile.Size = new System.Drawing.Size(146, 24);
            this.tsbDeleteFile.Text = "Remove selected";
            this.tsbDeleteFile.ToolTipText = "Remove selected (F6)";
            this.tsbDeleteFile.Click += new System.EventHandler(this.tsbDeleteFile_Click);
            // 
            // tsbDeleteAll
            // 
            this.tsbDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteAll.Image")));
            this.tsbDeleteAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteAll.Name = "tsbDeleteAll";
            this.tsbDeleteAll.Size = new System.Drawing.Size(107, 24);
            this.tsbDeleteAll.Text = "Remove all";
            this.tsbDeleteAll.ToolTipText = "Remove all (F7)";
            this.tsbDeleteAll.Click += new System.EventHandler(this.tsbDeleteAll_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.ssMain);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "proGEDIA Renamer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader chFolder;
        private System.Windows.Forms.ColumnHeader chFilename;
        private System.Windows.Forms.ColumnHeader chFullPath;
        private System.Windows.Forms.ColumnHeader chExtention;
        private System.Windows.Forms.ColumnHeader chPreview;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chDateCreated;
        private System.Windows.Forms.ColumnHeader chDateModified;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddFile;
        private System.Windows.Forms.ToolStripButton tsbAddFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDeleteFile;
        private System.Windows.Forms.ToolStripButton tsbDeleteAll;
    }
}

