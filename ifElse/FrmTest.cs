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
        int toplamTiklama = 0, uretilenSayiAdedi = 0, toplam = 0;
        public FrmTest()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            toplamTiklama++;
            lblToplamTiklama.Text = toplamTiklama.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger = rnd.Next(1000, 10000);
            if (checkBox1.Checked)
            {
                if ((deger % 2) == 0)
                    listBox1.Items.Add(deger);
                else
                {
                    deger--;
                    listBox1.Items.Add(deger);
                }
            }
            else
            {
                if ((deger % 2) == 1)
                    listBox1.Items.Add(deger);
                else
                {
                    deger--;
                    listBox1.Items.Add(deger);
                }
            }
            ++uretilenSayiAdedi;
            lblUretilenSayiAdedi.Text = uretilenSayiAdedi.ToString();

            toplam += deger;
            lblToplam.Text = toplam.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblToplamTiklama.Text = "";
            lblUretilenSayiAdedi.Text = "";
            lblToplam.Text = "";

            toplamTiklama = 0;
            uretilenSayiAdedi = 0;
            toplam = 0;
        }
    }
}
