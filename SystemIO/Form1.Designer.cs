
namespace SystemIO
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listDrive = new System.Windows.Forms.ListBox();
            this.listDirectory = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.listFile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Driver Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listDrive
            // 
            this.listDrive.FormattingEnabled = true;
            this.listDrive.Location = new System.Drawing.Point(23, 68);
            this.listDrive.Name = "listDrive";
            this.listDrive.Size = new System.Drawing.Size(116, 355);
            this.listDrive.TabIndex = 1;
            this.listDrive.SelectedIndexChanged += new System.EventHandler(this.listDrive_SelectedIndexChanged);
            // 
            // listDirectory
            // 
            this.listDirectory.FormattingEnabled = true;
            this.listDirectory.Location = new System.Drawing.Point(159, 68);
            this.listDirectory.Name = "listDirectory";
            this.listDirectory.Size = new System.Drawing.Size(197, 355);
            this.listDirectory.TabIndex = 2;
            this.listDirectory.SelectedIndexChanged += new System.EventHandler(this.listDirectory_SelectedIndexChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(537, 68);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(164, 355);
            this.treeView1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "TreeView Ornegi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listFile
            // 
            this.listFile.FormattingEnabled = true;
            this.listFile.Location = new System.Drawing.Point(362, 68);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(169, 355);
            this.listFile.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 536);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listDirectory);
            this.Controls.Add(this.listDrive);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listDrive;
        private System.Windows.Forms.ListBox listDirectory;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listFile;
    }
}

