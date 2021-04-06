using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPersonelGiris.VeriGiris;

namespace WinPersonelGiris
{



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
            
            AldigiEgitimler egitimler = new AldigiEgitimler();
            
            
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
