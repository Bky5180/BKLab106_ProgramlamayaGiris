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
    public partial class Form1 : Form
    {

        string Ad, soyad, tckimlik, gsm, email;
        DateTime dogumtarihi;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ad = txtAdi.Text;
            soyad = txtSoyad.Text;
            tckimlik = txtTcKimlik.Text;
            gsm = txtGsm.Text;
            email = txtEmail.Text;
            dogumtarihi = dtpDogumTarihi.Value;

            string veri = "Adi:" + Ad + "  Soyadi:" + soyad;
            veri += " TCK:" + tckimlik + " Gsm:" + gsm + " Email:" + email + " Dogum Tarihi:" + dogumtarihi.ToString();

            listBox1.Items.Add(veri);
        }
    }
}
