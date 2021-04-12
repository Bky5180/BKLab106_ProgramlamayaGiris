
namespace SystemIO.Onur_KIZILDAŞ
{
    partial class OK_TreeView
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
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnYukle = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 62);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(776, 861);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseMove);
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(12, 12);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(129, 44);
            this.btnYukle.TabIndex = 1;
            this.btnYukle.Text = "Dosyaları Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // OK_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 935);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OK_TreeView";
            this.Text = "Klasör ve Dosya Listeleme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}