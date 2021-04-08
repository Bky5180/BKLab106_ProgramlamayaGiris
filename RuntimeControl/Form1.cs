using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuntimeControl
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int[] mayinlar = new int[20];
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            /*
                toplam 165 adet picturebox var. 
                20 adet sayi olusturulacak
                20 ADET sayi random vaziyette 1-165 arasinda olusturulacak
                Bir dizide tutulacak.
                
         
            */

           
            for (int i = 0; i < mayinlar.Length; i++)
            {
                int mayin = rnd.Next(1, 166);
                if (mayinlar.Contains(mayin))
                {
                    i--;
                }
                else
                {
                    mayinlar[i] = mayin;
                }
                
                
            }


            for (int i = 0; i < 165; i++)
            {
                PictureBox pcb = new PictureBox();
                pcb.Width = 30;
                pcb.Height = 30;
                //pcb.Size = new System.Drawing.Size(50, 50);
                pcb.Margin = new Padding(1); // dış kenar boşluklar
                pcb.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

                if (mayinlar.Contains(i))
                    pcb.Tag = true;
                else
                    pcb.Tag = false;


                //picturebox'a tikladigimizda mayin var ise kullaniciya bildirim gidebilmesi icin click event'i ekliyoruz.
                pcb.Click += Pcb_Click;
                flowLayoutPanel1.Controls.Add(pcb);


            }
        }

        private void Pcb_Click(object sender, EventArgs e)
        {
            // sender o an tikladigimiz pictureboz'in tum ozelliklerini bize verir

            PictureBox pcb =(PictureBox)sender;
            Color color = pcb.BackColor;
            if ((bool)pcb.Tag == true)
            {
                timer1.Stop();

                foreach (var item in flowLayoutPanel1.Controls)
                {
                    pcb = (PictureBox)item;
                    pcb.BackColor = color;
                }
                MessageBox.Show("Mayin:" );
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                PictureBox pcb = (PictureBox)item;

                pcb.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            }
        }
    }
}
