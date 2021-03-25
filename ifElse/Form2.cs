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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici = txtBirinciDeger.Text;
            string sifre = txtikinciDeger.Text;

            if ((kullanici == "admin" && sifre == "1234"))
            {
                MessageBox.Show("Hosgeldiniz admin ..");
            }
            else if((kullanici == "admin" && sifre != "1234"))
            {
                MessageBox.Show("sifre yanlis ..");

            }
            else if ((kullanici != "admin" && sifre == "1234"))
            {
                MessageBox.Show("Kullanici Adi Yanlis ..");

            }
            else
            {
                MessageBox.Show("Ne Sifre Dogru nede Kullanici adi");

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /* Girilen not  0  - 30  araligi ise "FF" 
             *              30 - 50 araligi "DD" 
             *              50 - 70 "BB" 
             *              70 - 100 "AA" aldınız seklinde kullaniciyi uyariniz..
             * 
             */

            int not1 = int.Parse(txtBirinciDeger.Text);
            int not2 = int.Parse(txtikinciDeger.Text);
            int ortalama = (not1 + not2) / 2;
            if (ortalama >= 0 && ortalama < 30)
            {
                MessageBox.Show("FF");
            }
            else if (ortalama >= 30 && ortalama < 50)
            {
                MessageBox.Show("DD");
            }
            else if (ortalama >= 50 && ortalama < 70)
            {
                MessageBox.Show("BB");
            }
            else if (ortalama >= 70 && ortalama <= 100)
            {
                MessageBox.Show("AA");
            }
            else
            {
                MessageBox.Show("Yanlış not aralığı");
            }

            
        }

        //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
        //Domates, Biber, Patlican => Sebze Reyonu
        //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
        //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
        //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!

            string mesaj = "";
            if (txtBirinciDeger.Text == "Domates" || txtBirinciDeger.Text == "Biber" || txtBirinciDeger.Text == "Patlıcan")
            {
                mesaj = "Sebze reyonuna buyrun!";
            }
            else if (txtBirinciDeger.Text == "Diş Macunu" || txtBirinciDeger.Text == "Parfüm" || txtBirinciDeger.Text == "Şampuan")
            {
                mesaj = "Kozmetik reyonuna lütfen";
            }
            else if (txtBirinciDeger.Text == "Cep Telefonu" || txtBirinciDeger.Text == "Bilgisayar" || txtBirinciDeger.Text == "Ses Sistemi")
            {
                mesaj = "Teknoloji reyonunda bulabilirsiniz!";
            }
            else
            {
                mesaj = "Bu ürün karşıki markette!";
            }
            MessageBox.Show(mesaj);
        }
    }
}
