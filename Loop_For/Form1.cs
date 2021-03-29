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
            for (int deger = 0; deger < 1000; deger+=5)
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                listBox1.Items.Add(c + "-" + (int)c);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1-100 arasindaki cift sayilarin toplami ile tek sayilarin toplaminin farklarinin karesi kactir?

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 1945 gunumuze kadar yillari listbox'a ekleyelim. Ancak 2020 ve 1995 yilini eklemek istemiyorum.

        }
    }
}
