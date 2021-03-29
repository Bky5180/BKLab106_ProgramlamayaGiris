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
    public partial class FrmTest : Form
    {

        Random rnd = new Random();
        int toplamtiklama = 0;
        int uretilenSayiAdedi = 0;
        int toplam = 0;
        public FrmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int deger = rnd.Next(99999);
            if (checkBox1.Checked)
            {
                if ((deger % 2) == 0)
                {
                    listBox1.Items.Add(deger);
                }
                else
                {
                    deger++;
                    listBox1.Items.Add(deger);
                }

            }
            else
            {
                if ((deger % 2) == 1)
                    listBox1.Items.Add(deger);
                else
                {
                    deger++;
                    listBox1.Items.Add(deger);
                }
            }

            uretilenSayiAdedi++;
            toplam += deger;
            toplamtiklama++;
            lblToplamTiklama.Text = "Toplam Tıklama: " + toplamtiklama.ToString();
            lblUretilenSayiAdedi.Text = "Üretilen Sayı Adedi: " + uretilenSayiAdedi.ToString();
            lblToplam.Text = "Toplam: " + toplam.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            toplamtiklama = 0;
            uretilenSayiAdedi = 0;
            toplam = 0;
            lblToplamTiklama.Text = "Toplam Tıklama: " + toplamtiklama.ToString();
            lblUretilenSayiAdedi.Text = "Üretilen Sayı Adedi: " + uretilenSayiAdedi.ToString();
            lblToplam.Text = "Toplam: " + toplam.ToString();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            toplamtiklama++;
            lblToplamTiklama.Text = "Toplam Tıklama: " + toplamtiklama.ToString();
        }
    }
}
