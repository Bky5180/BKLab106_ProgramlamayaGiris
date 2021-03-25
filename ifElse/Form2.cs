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
        /*
          * MANTIKSAL OPERATORLER
          * Birden fazla durumun ayni anda kontrol edilmesi senaryosunda kullanilan operatorlerdir...
          * && (VE) (Kontrol blogu icerisinde yer alan tum kosullarin saglanmasi durumuna isaret eder... Kosullardan biri dahi saglanmazsa blogunuz harekete gecmez...)
          * || (VEYA) (Kontrol blogu icerisinde yer alan kosullardan herhangi birinin saglanmasi durumuna isaret eder... Boylece bir kosul bile saglansa blogunuza yazdiginiz kodlar harekete gecer...) Kısayol => ALTGR + Tire
          * 
          * Yukarıdaki operatorlere "kısa devre operatoru (shortcut operator)" adi verilir.. Kosullari kontrole en soldan baslar, herhangi bir uygunsuzluk durumunda diger kosullara asla bakmaz!.. Asagidaki operatorlerde ise, kosullar uysun ya da uymasin hepsi kontrol edilir...
          * 
          * & => VE
          * | => VEYA
          */

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

        private void btnSatisIslemi_Click(object sender, EventArgs e)
        {

            /* Disaridan siparis alinacak olan kitap miktari girilsin. 
            *  Sipari sayisi 20'den azsa toplam ucretten %5, 
            *      20 - 50 araliginda ise %10, 
            *      50-100 araligi ise %15, 
            *      100'den fazla ise %25 indirim yapilsin. 
            *      Kitabın birim fiyatı => 5 TLdir... 
            *      Amac => Odenecek tutari kullaniciya gostermek...
            * 
            */

            
            double birimFiyat = 5;
            double alinanSiparisMiktari = Convert.ToDouble(txtBirinciDeger.Text);
            double toplamOdenecekTutar = 0;

            if (alinanSiparisMiktari > 0 && alinanSiparisMiktari <= 20)
            {
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.95;
            }
            else if (alinanSiparisMiktari >= 21 && alinanSiparisMiktari <= 50)
            {
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.90;
            }
            else if (alinanSiparisMiktari >= 51 && alinanSiparisMiktari <= 100)
            {
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.85;
            }
            else if (alinanSiparisMiktari > 100)
            {
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.75;
            }

            MessageBox.Show("Ödemeniz gereken toplam tutar: " + toplamOdenecekTutar + " TL");
        }
    }
}
