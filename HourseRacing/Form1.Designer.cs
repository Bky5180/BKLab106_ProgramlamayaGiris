namespace HourseRacing
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblFinishCizgisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbBirinciAt = new System.Windows.Forms.PictureBox();
            this.pcbIkinciAt = new System.Windows.Forms.PictureBox();
            this.pcbUcuncuAt = new System.Windows.Forms.PictureBox();
            this.lblBilgilendirme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBirinciAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIkinciAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUcuncuAt)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(455, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yarisi Başlat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(633, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Yarisi Bitir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblFinishCizgisi
            // 
            this.lblFinishCizgisi.BackColor = System.Drawing.Color.White;
            this.lblFinishCizgisi.Location = new System.Drawing.Point(903, 80);
            this.lblFinishCizgisi.Name = "lblFinishCizgisi";
            this.lblFinishCizgisi.Size = new System.Drawing.Size(10, 377);
            this.lblFinishCizgisi.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-80, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(985, 10);
            this.label2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-80, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(985, 10);
            this.label1.TabIndex = 16;
            // 
            // pcbBirinciAt
            // 
            this.pcbBirinciAt.Image = global::HourseRacing.Properties.Resources.horse1;
            this.pcbBirinciAt.Location = new System.Drawing.Point(12, 151);
            this.pcbBirinciAt.Name = "pcbBirinciAt";
            this.pcbBirinciAt.Size = new System.Drawing.Size(126, 92);
            this.pcbBirinciAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBirinciAt.TabIndex = 19;
            this.pcbBirinciAt.TabStop = false;
            // 
            // pcbIkinciAt
            // 
            this.pcbIkinciAt.Image = global::HourseRacing.Properties.Resources.horse3;
            this.pcbIkinciAt.Location = new System.Drawing.Point(12, 259);
            this.pcbIkinciAt.Name = "pcbIkinciAt";
            this.pcbIkinciAt.Size = new System.Drawing.Size(126, 90);
            this.pcbIkinciAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIkinciAt.TabIndex = 20;
            this.pcbIkinciAt.TabStop = false;
            // 
            // pcbUcuncuAt
            // 
            this.pcbUcuncuAt.Image = global::HourseRacing.Properties.Resources.horse5;
            this.pcbUcuncuAt.Location = new System.Drawing.Point(12, 366);
            this.pcbUcuncuAt.Name = "pcbUcuncuAt";
            this.pcbUcuncuAt.Size = new System.Drawing.Size(126, 91);
            this.pcbUcuncuAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUcuncuAt.TabIndex = 21;
            this.pcbUcuncuAt.TabStop = false;
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.AutoSize = true;
            this.lblBilgilendirme.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.lblBilgilendirme.ForeColor = System.Drawing.Color.White;
            this.lblBilgilendirme.Location = new System.Drawing.Point(7, 9);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(0, 26);
            this.lblBilgilendirme.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(966, 537);
            this.Controls.Add(this.lblBilgilendirme);
            this.Controls.Add(this.pcbUcuncuAt);
            this.Controls.Add(this.pcbIkinciAt);
            this.Controls.Add(this.pcbBirinciAt);
            this.Controls.Add(this.lblFinishCizgisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBirinciAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIkinciAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUcuncuAt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblFinishCizgisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbBirinciAt;
        private System.Windows.Forms.PictureBox pcbIkinciAt;
        private System.Windows.Forms.PictureBox pcbUcuncuAt;
        private System.Windows.Forms.Label lblBilgilendirme;
    }
}

