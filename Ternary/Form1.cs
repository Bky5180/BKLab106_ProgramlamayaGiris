using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ternary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TERNARY OPERATORU
            //Tek satirda ufak bir karar mekanizmasi ile yolunuza devam etmek istiyorsaniz, soru isareti operatoru size bu pratikligi saglar. Yazim formati;
            // kontrolEdilecekDeger (KarsilastirmaOperatoru) ? Durumun Olumlu Olma Durumu : "Durumun Olumsuz Olma Durumu;

            string girilenDeger = "Bilge Adam";

            if (girilenDeger == "Bilge Adam")
            {
                this.Text = "Dogru Deger";
            }
            else
            {
                this.Text = "Hatali deger";
            }

            this.Text = girilenDeger == "Bilge Adam" ? "Doğru Değer" : "Hatalı Değer";
            string sonuc = 10 < 0 ? "Küçüktür" : "Büyüktür";
            
            
            MessageBox.Show(sonuc);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eger kullanici bir deger girdiyse MessageBox'la goster. Girmememise "default" bir deger goster...
            string girilenDeger = textBox1.Text.Length > 0 ? textBox1.Text : "Default Değer";
            MessageBox.Show(girilenDeger);
        }
    }
}
