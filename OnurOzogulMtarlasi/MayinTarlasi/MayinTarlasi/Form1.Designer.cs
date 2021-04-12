
namespace MayinTarlasi
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbseviye = new System.Windows.Forms.GroupBox();
            this.rbzor = new System.Windows.Forms.RadioButton();
            this.rborta = new System.Windows.Forms.RadioButton();
            this.rbklay = new System.Windows.Forms.RadioButton();
            this.btnOyna = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.gbseviye.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbseviye
            // 
            this.gbseviye.Controls.Add(this.rbzor);
            this.gbseviye.Controls.Add(this.rborta);
            this.gbseviye.Controls.Add(this.rbklay);
            this.gbseviye.Location = new System.Drawing.Point(534, 29);
            this.gbseviye.Name = "gbseviye";
            this.gbseviye.Size = new System.Drawing.Size(254, 147);
            this.gbseviye.TabIndex = 1;
            this.gbseviye.TabStop = false;
            this.gbseviye.Text = "Seviye";
            // 
            // rbzor
            // 
            this.rbzor.AutoSize = true;
            this.rbzor.Location = new System.Drawing.Point(7, 111);
            this.rbzor.Name = "rbzor";
            this.rbzor.Size = new System.Drawing.Size(84, 21);
            this.rbzor.TabIndex = 2;
            this.rbzor.TabStop = true;
            this.rbzor.Text = "Valla zor";
            this.rbzor.UseVisualStyleBackColor = true;
            this.rbzor.CheckedChanged += new System.EventHandler(this.rbzor_CheckedChanged);
            // 
            // rborta
            // 
            this.rborta.AutoSize = true;
            this.rborta.Location = new System.Drawing.Point(7, 75);
            this.rborta.Name = "rborta";
            this.rborta.Size = new System.Drawing.Size(72, 21);
            this.rborta.TabIndex = 1;
            this.rborta.TabStop = true;
            this.rborta.Text = "Eh Iste";
            this.rborta.UseVisualStyleBackColor = true;
            this.rborta.CheckedChanged += new System.EventHandler(this.rborta_CheckedChanged);
            // 
            // rbklay
            // 
            this.rbklay.AutoSize = true;
            this.rbklay.Location = new System.Drawing.Point(7, 35);
            this.rbklay.Name = "rbklay";
            this.rbklay.Size = new System.Drawing.Size(64, 21);
            this.rbklay.TabIndex = 0;
            this.rbklay.TabStop = true;
            this.rbklay.Text = "Kolay";
            this.rbklay.UseVisualStyleBackColor = true;
            this.rbklay.CheckedChanged += new System.EventHandler(this.rbklay_CheckedChanged);
            // 
            // btnOyna
            // 
            this.btnOyna.Location = new System.Drawing.Point(534, 183);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(244, 61);
            this.btnOyna.TabIndex = 2;
            this.btnOyna.Text = "Oyna";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(534, 251);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(20, 17);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "...";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(534, 283);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(45, 17);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Puan:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.gbseviye);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbseviye.ResumeLayout(false);
            this.gbseviye.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbseviye;
        private System.Windows.Forms.RadioButton rbzor;
        private System.Windows.Forms.RadioButton rborta;
        private System.Windows.Forms.RadioButton rbklay;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

