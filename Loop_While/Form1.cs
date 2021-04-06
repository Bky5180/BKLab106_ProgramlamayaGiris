using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string personel = "";
            personel = textBox1.Text;
            personel += " " + textBox2.Text;
            personel += " " + textBox3.Text;
            personel += " " + textBox4.Text;


            listBox1.Items.Add(personel);
            ekraniTenmizle();
        }
        public void ekraniTenmizle()
        {
            int index = 0;

            // From Uzerindeki nesnelere ulasmak icin 
            //while (index < this.Controls["groupBox1"].Controls.Count)
            //{
            //    if (this.Controls["groupBox1"].Controls[index] is TextBox)
            //    {
            //        this.Controls["groupBox1"].Controls[index].Text = "";
            //    }

            //    index++;
            //}


            // Direk groupBox icerisindeki nesnelere ulasmak icin
            while (index < groupBox1.Controls.Count)
            {
                if (groupBox1.Controls[index] is TextBox)
                {
                    groupBox1.Controls[index].Text = "";
                }

                index++;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int faktoryel = 1;
            int i = 5;
            while (i>0)
            {
                faktoryel = faktoryel * i;
                i--;
            }

            MessageBox.Show(faktoryel.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int faktoryel = 1;
            int i = 5;
            do
            {
                faktoryel = faktoryel * i;
                i--;
            } while (i > 0);

            MessageBox.Show(faktoryel.ToString());
        }
    }
}
