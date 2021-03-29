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
        int toplamTiklama = 0, uretilenSayiAdedi = 0, toplam;
        public FrmTest()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            toplamTiklama += 1;
            lblToplamTiklama.Text = toplamTiklama.ToString();

            int deger = rnd.Next(1000, 10000);
            if (checkBox1.Checked)
            {
                if ((deger % 2) == 0)
                    listBox1.Items.Add(deger);
            }
            else
            {
                if ((deger % 2) == 1)
                    listBox1.Items.Add(deger);
            }
            uretilenSayiAdedi = listBox1.Items.Count;
            lblUretilenSayiAdedi.Text = uretilenSayiAdedi.ToString();

            toplam = 0;
            for (int i = 0; i < uretilenSayiAdedi; i++)
            {
                toplam += (int)listBox1.Items[i];
            }
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
        }
    }
}
