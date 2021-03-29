using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourseRacing
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bir kontrolun "Left" property'si, o kontrolun sola olan uzakligini size teslim eder...
            //Bir kontrolun Left ve Top ozelliklerine atama yapabilirsiniz ancak Right ve Bottom ozelliklerinden yalnizca o anki degerlerini alabilirsiniz...
            pcbBirinciAt.Left += rnd.Next(5, 16);
            pcbIkinciAt.Left += rnd.Next(5, 16);
            pcbUcuncuAt.Left += rnd.Next(5, 16);


            if (pcbBirinciAt.Left > pcbIkinciAt.Left && pcbBirinciAt.Left > pcbUcuncuAt.Left)
            {
                lblBilgilendirme.Text = "Birinci kulvardaki at önde götürüyor...";
            }
            else if (pcbIkinciAt.Left > pcbBirinciAt.Left && pcbIkinciAt.Left > pcbUcuncuAt.Left)
            {
                lblBilgilendirme.Text = "İkinci kulvardaki at önde götürüyor...";
            }
            else if (pcbUcuncuAt.Left > pcbBirinciAt.Left && pcbUcuncuAt.Left > pcbIkinciAt.Left)
            {
                lblBilgilendirme.Text = "Üçüncü kulvardaki at önde götürüyor...";
            }

            //Bir kontrolun "Width" ozelligi, o kontrolun genisligini size teslim eder...
            //Bir kontrolun "Height" ozelligi, o kontrolun yuksekligini size teslim eder...
            if (pcbBirinciAt.Left + pcbBirinciAt.Width >= lblFinishCizgisi.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı birinci kulvardaki atımız kazandı!");
            }
            else if (pcbIkinciAt.Left + pcbIkinciAt.Width >= lblFinishCizgisi.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı ikinci kulvardaki atımız kazandı!");
            }
            else if (pcbUcuncuAt.Left + pcbUcuncuAt.Width >= lblFinishCizgisi.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı üçüncü kulvardaki atımız kazandı!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
    }
}
