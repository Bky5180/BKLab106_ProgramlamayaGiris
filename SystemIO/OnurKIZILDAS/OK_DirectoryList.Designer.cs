
namespace SystemIO
{
    partial class OK_DirectoryList
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listDrive = new System.Windows.Forms.ListBox();
            this.listFile = new System.Windows.Forms.ListBox();
            this.listDirectory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.listDrive);
            this.splitContainer1.Panel1.Controls.Add(this.listFile);
            this.splitContainer1.Panel1.Controls.Add(this.listDirectory);
            this.splitContainer1.Size = new System.Drawing.Size(895, 740);
            this.splitContainer1.SplitterDistance = 866;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(96, 11);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(0, 17);
            this.lblDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktif Dizin:";
            // 
            // listDrive
            // 
            this.listDrive.FormattingEnabled = true;
            this.listDrive.ItemHeight = 16;
            this.listDrive.Location = new System.Drawing.Point(12, 42);
            this.listDrive.Name = "listDrive";
            this.listDrive.Size = new System.Drawing.Size(120, 692);
            this.listDrive.TabIndex = 2;
            this.listDrive.SelectedIndexChanged += new System.EventHandler(this.ListDrive_SelectedIndexChanged);
            // 
            // listFile
            // 
            this.listFile.FormattingEnabled = true;
            this.listFile.HorizontalScrollbar = true;
            this.listFile.ItemHeight = 16;
            this.listFile.Location = new System.Drawing.Point(464, 42);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(389, 692);
            this.listFile.TabIndex = 4;
            // 
            // listDirectory
            // 
            this.listDirectory.FormattingEnabled = true;
            this.listDirectory.HorizontalScrollbar = true;
            this.listDirectory.ItemHeight = 16;
            this.listDirectory.Location = new System.Drawing.Point(138, 42);
            this.listDirectory.Name = "listDirectory";
            this.listDirectory.Size = new System.Drawing.Size(320, 692);
            this.listDirectory.TabIndex = 3;
            this.listDirectory.SelectedIndexChanged += new System.EventHandler(this.ListDirectory_SelectedIndexChanged);
            // 
            // OK_DirectoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 764);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OK_DirectoryList";
            this.Text = "OK_DirectoryList";
            this.Load += new System.EventHandler(this.OK_DirectoryList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listDrive;
        private System.Windows.Forms.ListBox listFile;
        private System.Windows.Forms.ListBox listDirectory;
    }
}