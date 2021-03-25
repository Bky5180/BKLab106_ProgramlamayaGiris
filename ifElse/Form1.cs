using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdminKontrolu_Click(object sender, EventArgs e)
        {
            string gelenDeger = txtGirisAlani.Text;
            bool lg = false;

            // Kullanimi () seklinde olacak. Parantez icerisndeki ifade true oldugunda scope icerisine girecektir. Yanliş ise else kismina girecektir.

            //if (lg) 
            //if(lg==false)
            //if(!lg)
            //if(lg!=true)
            if(gelenDeger=="admin")
            {

                // Admin islemleri
                MessageBox.Show("Hosgeldiniz");

            }
            else
            {
                MessageBox.Show("Yetkiniz Yok");
            }
        }

        private void btnNotKontrolu_Click(object sender, EventArgs e)
        {
            string gelenDeger = txtGirisAlani.Text;
            int not = Convert.ToInt32(gelenDeger);
            if (not >= 50)
            {
                MessageBox.Show("Geçtiniz");
            }
            else
            {
                MessageBox.Show("Kaldiniz");
            }
        }

        private void btnCiftMiTekMi_Click(object sender, EventArgs e)
        {

            // 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gelenDeger = txtGirisAlani.Text;
            
            if (gelenDeger.Length==11 )
            {
                MessageBox.Show("Geçerli Format");
            }
            else if(gelenDeger.Length > 11)
            {
                MessageBox.Show("11 karekter den buyuk .Geçersiz Format");
            }
            else if (gelenDeger.Length < 11)
            {
                MessageBox.Show("11 karekter den kucuk .Geçersiz Format");
            }
        }

        private void btnDegerKontrolu_Click(object sender, EventArgs e)
        {
            // Girilen ifade'ye gore mobile olup olmadigina bakalim
            string gelenDeger = txtGirisAlani.Text;
            // Olasiliklar :        5321233322 ,
            //  05422221111,
            //  905353223322 ,          
            //  +905459998877 ,
            //  02123334455,
            //  08507770000,
            //  4440333
            // 53,54,55,50
            // string temp = gelenDeger.Substring(gelenDeger.Length -, 10);
            // string alankod = temp.PadLeft(3); // 5 ise gsm numarasidir .
            

            //MessageBox.Show($"Alinan {gelenDeger} , AlanKodu:{alankod} ");

            //if (alankod.PadLeft(1) == "5")
            //{
            //    MessageBox.Show("Gsm Operatorudur");
            //}
            //else
            //{
            //    MessageBox.Show("Gelen Numara:"+gelenDeger);
            //}

        }
    }
}
