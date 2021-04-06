using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPersonelGiris
{
    public struct Personel
    {
        public string Ad;
        public string soyad;
        string _tckimlik; //11 Haneli olup olmadigini kontol 
        public string gsm;
        public string email;
        public DateTime dogumtarihi;
        public Hobiler hobi;
        public Adres adres;

        public string SetTcKimlik(string tckimlik)
        {
            string str = "";
            if (tckimlik.Length == 11)
            {
                _tckimlik = tckimlik;
                str = "Ok";
            }
            else
            {
                str = "Verilen deger 11 karakter uzunlugunda degildir";
            }

            return str;
        }
        public string GetTcKimlik()
        {
            if (_tckimlik == null)
                return "TcKimlik Tanimli Degildir";
            else
                return "********"+_tckimlik.Substring(8);
        }
    }
    public struct Adres
    {
        public int adresTipi;
        public string Sehir;
        public string Ilce;
        public string AcikAdres;
    
    }

    public struct Hobiler
    {
        public string hobi;
    }
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
           string str =  p.SetTcKimlik(txtTcKimlik.Text);

            p.Ad = txtAdi.Text;
           p.soyad = txtSoyad.Text;
           //p.tckimlik = txtTcKimlik.Text;
           p.gsm = txtGsm.Text;
           p.email = txtEmail.Text;
           p.dogumtarihi = dtpDogumTarihi.Value;




            Adres adr = new Adres();
            adr.adresTipi = 1;
            adr.Sehir = "van";
            adr.Ilce = "Tatvan";



            p.adres = adr;


            string veri = "Adi:" + p.Ad + "  Soyadi:" + p.soyad;
            veri += " TCK:" + p.GetTcKimlik() + " Gsm:" + p.gsm + " Email:" + p.email + " Dogum Tarihi:" + p.dogumtarihi.ToString();

            listBox1.Items.Add(veri);
            listBox1.Items.Add(p.ToString());
        }
    }


   
}
