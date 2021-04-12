using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(); 
        Random rnd = new Random();
        List<int> mayın = new List<int>();
        int point, NombreDeClique = 0, NombreDeMine = 0, Boite = 0;

        private void rborta_CheckedChanged(object sender, EventArgs e)
        {
            if (rborta.Checked == true)
                lbl1.Text = "Mayin sayisi: 25";
        }

        private void rbzor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbzor.Checked == true)
                lbl1.Text = "Mayin sayisi: 40";
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            if (rbklay.Checked == true)
                Oyna("kolay");
            else if (rborta.Checked == true)
                Oyna("orta");
            else if (rbzor.Checked == true)
                Oyna("zor");
            else
                MessageBox.Show("Zorluk Seçin");
        }

        private void rbklay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbklay.Checked == true)
                lbl1.Text = "Mayin sayisi: 10";
        }

        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "ABVwav.wav";
            player2.SoundLocation = "IWSwav.wav";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Oyna(string mod)
        {
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.Controls.Clear();
            mayın.Clear();
            NombreDeClique = 0;
            NombreDeMine= 0;
            Boite = 0;
            point = 0;
            lbl2.Text = "PUAN: 0";

            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.RowCount = 10;

            if (mod == "kolay") NombreDeMine = 10;
            else if (mod == "orta") NombreDeMine = 25;
            else if (mod == "zor") NombreDeMine = 40;

            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

                for (int x = 0; x < tableLayoutPanel1.RowCount; x++)
                {
                    if (i == 0)
                    {
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    }
                    Button cmd = new Button();
                    cmd.BackColor = Color.Gray;
                    cmd.Dock = DockStyle.Fill;
                    cmd.Name = Boite.ToString();
                    tableLayoutPanel1.Controls.Add(cmd, i, x);
                    Boite++;
                }
            }
            int randomsayi;
            for (int i = 0; i < NombreDeMine; i++)
            {
                do
                {
                    randomsayi = rnd.Next(1, (tableLayoutPanel1.ColumnCount * tableLayoutPanel1.RowCount) - 1);

                } while (mayın.Contains(randomsayi));

                mayın.Add(randomsayi);
            }

            ButtonClickAyarla();
        }
        private void ButtonClickAyarla()
        {
            foreach (Control ctl in this.tableLayoutPanel1.Controls)
            {
                ctl.MouseClick += new MouseEventHandler(Form1_MouseClick);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Event(sender);
        }
        private void Event(object sender)
        {
            if (sender.GetType().Name == "Button")
            {
                Button tiklanan = (Button)sender;
                if (tiklanan.BackColor != Color.Green && tiklanan.BackColor != Color.Red)
                {
                    string isim = tiklanan.Name;
                    if (mayın.IndexOf(Convert.ToInt32(isim)) != -1) // Yandın
                    {
                        tiklanan.BackColor = Color.Red;
                        
                        HepsiniAc();
                        player.Play();
                        MessageBox.Show("Kaybettin Ulen. \nPuan: " + point);
                        player.Stop();
                    }
                    else // Kazandın
                    {
                        tiklanan.BackColor = Color.Green;
                        Random rnd = new Random();
                        int tikpuan = rnd.Next(1, NombreDeMine);
                        point += tikpuan;
                        tiklanan.Text = tikpuan.ToString();
                        lbl2.Text = "Puan: " + point.ToString();

                        if (NombreDeClique == ((tableLayoutPanel1.ColumnCount * tableLayoutPanel1.RowCount) - 1) - NombreDeMine)
                        {
                            HepsiniAc();
                            player2.Play(); 
                            MessageBox.Show("Naaaferim Uleynn \nPoint " + point);
                        }
                        else
                        {
                            NombreDeClique++;
                        }
                    }
                }
            }
        }
        private void HepsiniAc()
        {
            for (int i = 0; i <= (tableLayoutPanel1.ColumnCount * tableLayoutPanel1.RowCount) - 1; i++)
            {
                Button btn = (Button)tableLayoutPanel1.Controls[i];
                if (mayın.IndexOf(Convert.ToInt32(btn.Name)) != -1)
                {
                    btn.BackColor = Color.Red;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                  
                }
                else
                {
                    btn.BackColor = Color.Green;
                }
            }
        }
    }
}
