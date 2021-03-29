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
                    deger = rnd.Next(99999);
                }
              
            }
            else
            {
                 
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
