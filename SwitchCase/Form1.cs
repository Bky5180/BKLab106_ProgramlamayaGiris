using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
        * SWITCH - CASE
        * IF-Else mantigiyle calisan bir kontrol mekanizmasidir. Aradaki fark, if-else yapisi buyukluk-kucukluk gibi durumlari kontrol ederken,
        * switch-case yalnizca esitlik durumlarini kontrol edebilen karar yapimizdir.. Kendisine ait bir index mekanizmasi ile kosullari algilar, 
        * siraya koyar ve otomatik olarak yuzlerce kosulunuz olsa bile herbirine bakmadan hangisine uydugunu bulabilir. Bu da performansı direktman etkiler...
        * Switch blogu icerisine yazdiginiz veri tipiniz ne ise, case (durum) olarak belirttiginiz tum veriler de ayni veri tipinde olmalıdır!
        * break => Kosul saglandi, artik karar yapisindan kendini disari atabilirsin mesajini sisteme verir...
        */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // disaridan Mevsim Girilsin , aylar donsun
            #region Normal if ile
            string mesaj = ""
;
            //if (txtGiris.Text == "İlkBahar")
            //{
            //    mesaj = "Mart,Nisan,Mayis";

            //}
            //else if (txtGiris.Text == "Yaz")
            //{
            //    mesaj = "Haziran,Temmuz,Agustos";
            //}
            //else if (txtGiris.Text == "Sonbahar")
            //{
            //    mesaj = "Eylul,Ekim,Kasim";
            //}
            //else if (txtGiris.Text == "Kış")
            //{
            //    mesaj = "Aralik,Ocak,Subat";
            //}
            #endregion

            #region SwitchCase
            switch (txtGiris.Text.ToUpper())
            {
                case "İLKBAHAR":
                    mesaj = "Mart,Nisan,Mayis";
                    break;
                case "YAZ":
                    mesaj = "Haziran,Temmuz,Agustos";
                    break;
                case "SONBAHAR":
                    mesaj = "Eylul,Ekim,Kasim";
                    break;
                case "KIŞ":
                    mesaj = "Aralik,Ocak,Subat";
                    break;
                default: // Ongorulen bir durum harici degerler ile karsilasilirsa ,varsayilan olarak karar yapisi ne gibi bir islem uygulansin. Tamamen opsiyoneldir. Kullanmasak da olur
                    mesaj = "Boyle bir mevsim hiz duymadim !!";
                    break;
            }

            #endregion
            MessageBox.Show(mesaj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Eger ilk textbox 'a admin,yonetici,ceo,baskan degerleri yazilirsa yonetim paneline yonlendiriliyosunuz mesajı versin
            //Eger Uye yazilmis ise Ana sayfaya yonlendiriliyorsunuz yazsin.


            string girilenDeger = txtGiris.Text.ToLower();
            string mesaj = "";
            switch (girilenDeger)
            {
                case "admin":
                case "yonetici":
                case "ceo":
                case "baskan":
                    mesaj = "Yonetim Paneline Yonlendiriliyorsunuz";
                    break;

                case "uye":
                    mesaj = "Ana sayfaya Yonlendiriliyorsunuz";
                    break;
                default:
                    mesaj = "Bu sayfayi gorme yetikiniz yok";
                    break;
            }

            MessageBox.Show(mesaj);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // birinci textbox kullanici adi olsun
            // ikinci giris alaninda ise sifre istensin
            // kullanici adi :"bilgeadam" , sifre :"1234"

            //Eger hem kullanici adi hemde sifre dogru girildiyse "Tebrikler giris Basarili" yazsin, 
            // Eger kullanici adi dogru sifre yazlis ise "Kullanici adi dogru ancak sifre hatali" mesajını versin
            // Eger sifre dogru kullanici adi yazliş ise "Kullanici Adini yanşliş girdiniz" mesajı versin

            string kullaniciAdi = txtGiris.Text.ToLower();
            string sifre = txtIkinciGiris.Text;
            string mesaj = "";

            switch (kullaniciAdi)
            {
                case "bilgeadam":
                    switch (sifre)
                    {
                        case "1234":
                            mesaj = "Tebrikler giriş başarılı";
                            break;
                        default:
                            mesaj = "Kullanıcı adı doğru ancak şifre hatalı";
                            break;
                    }
                    break;
                default:
                    switch (sifre)
                    {
                        case "1234":
                            mesaj = "Şifre doğru ancak kullanıcı adını yanlış girdiniz";
                            break;
                        default:
                            mesaj = "Hem kullanıcı adı hem şifreyi yanlış girdiniz";
                            break;
                    }
                    break;
            }
            MessageBox.Show(mesaj);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int date = DateTime.Now.Year;
            for (int i = 1945; i <= date; i++)
            {
                if (i == 1995 || i == 2020)
                    continue;

                listBox1.Items.Add(i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int tekToplam = 0, ciftToplam = 0, fark = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    ciftToplam += i;

                else
                    tekToplam += i;
            }
            fark = ciftToplam - tekToplam;
            MessageBox.Show(Math.Pow(fark, 2).ToString());
        }
    }
}
