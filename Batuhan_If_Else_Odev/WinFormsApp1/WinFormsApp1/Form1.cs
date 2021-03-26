using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Formun ilk acilis aninda 8 haneli rastgele bir sayı lblRastgeleKarakterler 
        * adli label'a yazdirilacak ve kullanicidan butona bastigi anda 
        * textbox'taki yazıyla label'daki yazının karsilastirmasi yapilacak. 
        * 
        * Eger karsilastirma olumsuz ise lblKalanHakkimiz'deki deger bir azaltılacak. 
         
        Eger kullanici 5 defa hatali giris yaparsa button'un aktiflik ozelligi kapatilacak...
        
        Her hatali giriste yeni bir rastgele sayi turetilmelidir...
       */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int gelensayi = Convert.ToInt32(textBox1.Text);
                int labelverisi = Convert.ToInt32(label2.Text);

                if (gelensayi == labelverisi)
                {
                    MessageBox.Show("Sayılar Eşleşti...");
                }
                else if (textBox1.Text != label2.Text)
                {
                    Random sayi = new Random();
                    int d = sayi.Next(99999999);
                    label2.Text = Convert.ToString(d);

                    textBox1.Clear();

                    int label4verisi = Convert.ToInt32(label4.Text);

                    label4.Text = Convert.ToString(--label4verisi);

                    if (label4verisi == 0)
                    {
                        MessageBox.Show("Deneme Hakkınız Bitmiştir...");
                        button1.Enabled = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Rakam Değeri Girmeden Butona Tıklamayınız...");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random sayi = new Random();
            int rastgele = sayi.Next(99999999);

            label2.Text = (rastgele.ToString());

            label4.Text = ("5");
        }
    }
}
