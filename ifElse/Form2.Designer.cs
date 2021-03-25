namespace ifElse
{
    partial class Form2
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
            this.txtBirinciDeger = new System.Windows.Forms.TextBox();
            this.txtikinciDeger = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBirinciDeger
            // 
            this.txtBirinciDeger.Location = new System.Drawing.Point(26, 13);
            this.txtBirinciDeger.Name = "txtBirinciDeger";
            this.txtBirinciDeger.Size = new System.Drawing.Size(309, 20);
            this.txtBirinciDeger.TabIndex = 0;
            // 
            // txtikinciDeger
            // 
            this.txtikinciDeger.Location = new System.Drawing.Point(26, 50);
            this.txtikinciDeger.Name = "txtikinciDeger";
            this.txtikinciDeger.Size = new System.Drawing.Size(309, 20);
            this.txtikinciDeger.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giris Kontrol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Not Kontrol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Reyon Kontrol";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtikinciDeger);
            this.Controls.Add(this.txtBirinciDeger);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirinciDeger;
        private System.Windows.Forms.TextBox txtikinciDeger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}