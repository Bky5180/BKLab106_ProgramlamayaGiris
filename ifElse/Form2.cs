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

            string not1 = txtBirinciDeger.Text;
            string not2 = txtikinciDeger.Text;


        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

      
    }
}
