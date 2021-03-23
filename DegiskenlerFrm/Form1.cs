using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegiskenlerFrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2,toplam;
            double x;
            float f;

            //sayi1 = int.Parse(textBox1.Text);
            //sayi2 = int.Parse(textBox2.Text);
            sayi1 = 10;
            sayi2 = 3;
            
            sayi1++; //11

            //sayi1 = sayi2++; // Once atama sonra arttirma
            //sayi1 = 10;
            //sayi1 = ++sayi2;// Once arttirma ,sonra atama
            //sayi1 = sayi2--;// 
            //sayi1 = --sayi2;// 


            sayi1 += sayi2;// 14 ,3
            sayi1 += sayi2++; // 16,4
            sayi1 -= ++sayi2;// 11,5
            
            
            // ikinci cevirme yontemi cast ifadesi ile yapilabilir
            x = (double)sayi1 / sayi2;
            f = sayi1 / (float)sayi2;

            // Mode alma

            MessageBox.Show(f.ToString());

            //label1.Text = (sayi1 % sayi2).ToString();




            //(sayi1 + sayi2).ToString();
        }

      

    }
}
