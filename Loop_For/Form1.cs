using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop_For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Donguye ilk girdiginde derleyici baslangic degerine bakar.
            // bir daha asla buraya bakmaz.
            //Bundan sonraki islmler  once arttir ,sonra kontrol et seklindedir.
            //Eger kosul uygunsa scope icerisindeki blogu calistir.
            // Kosul eger uygun degilse donguden cikar

            // for(balangicDegeri;BitişKosulu;ArtisMiktari

            listBox1.Items.Clear();

            for (int deger = 1; deger <= 1000; deger++)
            {
                listBox1.Items.Add(deger);
            }


            //for (int i = 1000; i > 0; i--)
            //{
            //    listBox1.Items.Add(i);

            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[]  yas = new int[12];

            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                listBox1.Items.Add(c + "-" + (int)c);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1-100 arasindaki cift sayilarin toplami ile tek sayilarin toplaminin farklarinin karesi kactir?
            // camel case 
            int ciftToplam = 0, tekToplam = 0;

            // Pascal case
            int fark = 0, TekKare;

            // snack case 
            int cift_Toplam_sayilar;
            int tek_Toplam_;

            for (int i = 1; i <= 100; i++)
            {

                // eger Tek satirlik komut varsa scope acmaya gerek yoktur
                if (i % 2 == 0)
                    ciftToplam += i;
                else
                    tekToplam += i;
            }
            fark = (int)Math.Pow(ciftToplam - tekToplam, 2);
            MessageBox.Show(fark.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 1945 gunumuze kadar yillari listbox'a ekleyelim. Ancak 2020 ve 1995 yilini eklemek istemiyorum.
            listBox1.Items.Clear();
            int year = DateTime.Now.Year;
            for (int i = 1945; i <= year; i++)
            {
                //if (i != 1995 && i != 2020)
                //    listBox1.Items.Add(i);

                if (i == 1995 || i == 2020)
                    continue;

                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i <= 1000; i++)
            {
                if (!(i % 2 == 0))
                    continue;
                else
                    listBox1.Items.Add(i);
            }
        }
    }
}
