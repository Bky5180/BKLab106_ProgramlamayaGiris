namespace ifElse
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
            this.btnAdminKontrolu = new System.Windows.Forms.Button();
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.btnNotKontrolu = new System.Windows.Forms.Button();
            this.btnCiftMiTekMi = new System.Windows.Forms.Button();
            this.btnDegerKontrolu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminKontrolu
            // 
            this.btnAdminKontrolu.Location = new System.Drawing.Point(2, 44);
            this.btnAdminKontrolu.Name = "btnAdminKontrolu";
            this.btnAdminKontrolu.Size = new System.Drawing.Size(300, 40);
            this.btnAdminKontrolu.TabIndex = 8;
            this.btnAdminKontrolu.Text = "ADMİN KONTROLÜ";
            this.btnAdminKontrolu.UseVisualStyleBackColor = true;
            this.btnAdminKontrolu.Click += new System.EventHandler(this.btnAdminKontrolu_Click);
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(2, 12);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(300, 20);
            this.txtGirisAlani.TabIndex = 7;
            // 
            // btnNotKontrolu
            // 
            this.btnNotKontrolu.Location = new System.Drawing.Point(2, 100);
            this.btnNotKontrolu.Name = "btnNotKontrolu";
            this.btnNotKontrolu.Size = new System.Drawing.Size(300, 40);
            this.btnNotKontrolu.TabIndex = 9;
            this.btnNotKontrolu.Text = "NOT KONTROLÜ";
            this.btnNotKontrolu.UseVisualStyleBackColor = true;
            this.btnNotKontrolu.Click += new System.EventHandler(this.btnNotKontrolu_Click);
            // 
            // btnCiftMiTekMi
            // 
            this.btnCiftMiTekMi.Location = new System.Drawing.Point(4, 146);
            this.btnCiftMiTekMi.Name = "btnCiftMiTekMi";
            this.btnCiftMiTekMi.Size = new System.Drawing.Size(300, 40);
            this.btnCiftMiTekMi.TabIndex = 10;
            this.btnCiftMiTekMi.Text = "ÇİFT - TEK KONTROLÜ";
            this.btnCiftMiTekMi.UseVisualStyleBackColor = true;
            this.btnCiftMiTekMi.Click += new System.EventHandler(this.btnCiftMiTekMi_Click);
            // 
            // btnDegerKontrolu
            // 
            this.btnDegerKontrolu.Location = new System.Drawing.Point(4, 201);
            this.btnDegerKontrolu.Name = "btnDegerKontrolu";
            this.btnDegerKontrolu.Size = new System.Drawing.Size(300, 40);
            this.btnDegerKontrolu.TabIndex = 11;
            this.btnDegerKontrolu.Text = "TELEFON  KONTROLÜ";
            this.btnDegerKontrolu.UseVisualStyleBackColor = true;
            this.btnDegerKontrolu.Click += new System.EventHandler(this.btnDegerKontrolu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "TCKIMLIK  KONTROLÜ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDegerKontrolu);
            this.Controls.Add(this.btnCiftMiTekMi);
            this.Controls.Add(this.btnNotKontrolu);
            this.Controls.Add(this.btnAdminKontrolu);
            this.Controls.Add(this.txtGirisAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminKontrolu;
        private System.Windows.Forms.TextBox txtGirisAlani;
        private System.Windows.Forms.Button btnNotKontrolu;
        private System.Windows.Forms.Button btnCiftMiTekMi;
        private System.Windows.Forms.Button btnDegerKontrolu;
        private System.Windows.Forms.Button button1;
    }
}

