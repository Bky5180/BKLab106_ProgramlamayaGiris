using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            //Mouse alana girdigi anda, textbox'un arkaplan ve yazi rengi degissin...
            textBox1.BackColor = Color.Maroon;
            textBox1.ForeColor = Color.Orange;
           
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ulong yazilan = (ulong)textBox2.Text.Length;
            label2.Text = yazilan.ToString();

        }
    }
}
