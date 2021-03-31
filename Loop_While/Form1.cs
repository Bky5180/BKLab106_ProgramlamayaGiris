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
            //index = this.Controls["groupBox1"].Controls.Count;
            //foreach (var item in this.Controls["groupBox1"].Controls)
            //{
            //    if (item is TextBox)
            //    {
                    
            //    }
            //}

            while (index < this.Controls["groupBox1"].Controls.Count)
            {
                if (this.Controls["groupBox1"].Controls[index] is TextBox)
                {
                    this.Controls["groupBox1"].Controls[index].Text = "";
                }

                index++;
            }

        
        }
    }
}
