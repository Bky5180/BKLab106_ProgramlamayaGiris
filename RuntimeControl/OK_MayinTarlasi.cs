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
    public partial class OK_MayinTarlasi : Form
    {
        Random rnd = new Random();
        PictureBox pcb;
        int[] mayinlar = new int[20];
        int[] pcbes = new int[165];
        public OK_MayinTarlasi()
        {
            InitializeComponent();
        }

        private void OK_MayinTarlasi_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < mayinlar.Length; i++)
            {
                int mayin = rnd.Next(1, 166);
                if (mayinlar.Contains(mayin))
                    i--;
                else
                    mayinlar[i] = mayin;
            }
            for (int i = 0; i < 165; i++)
            {
                pcb = new PictureBox()
                {
                    Width = 30,
                    Height = 30,
                    Margin = new Padding(1), // dış kenar boşluklar
                    BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256))
                    //Size = new System.Drawing.Size(50, 50)
                };
                if (mayinlar.Contains(i))
                {
                    pcb.Tag = true;
                    pcbes[i] = i + 1;
                }
                else
                {
                    pcb.Tag = false;
                    pcbes[i] = i + 1;
                }
                //picturebox'a tikladigimizda mayin var ise kullaniciya bildirim gidebilmesi icin click event'i ekliyoruz.
                pcb.Click += Pcb_Click;
                flowLayoutPanel1.Controls.Add(pcb);
            }
        }
        private void Pcb_Click(object sender, EventArgs e)
        {
            // sender o an tikladigimiz pictureboz'in tum ozelliklerini bize verir
            pcb = (PictureBox)sender;
            //Graphics graph = pcb.CreateGraphics();

            int sayac = 0;
            if ((bool)pcb.Tag == true)
            {
                timer1.Stop();
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    sayac++;
                    pcb = (PictureBox)item;

                    if (!mayinlar.Contains(pcbes[sayac - 1]))
                        pcb.BackColor = Color.White;
                    else
                    {
                        pcb.BackColor = Color.Red;
                        //graph.DrawString(pcbes[sayac - 1].ToString(), DefaultFont, Brushes.Black, new PointF(pcb.Location.X, pcb.Location.Y));
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                pcb = (PictureBox)item;
                pcb.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            }
        }
    }
}