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
    public partial class Form3 : Form
    {
      



        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            /* Formun ilk acilis aninda 8 haneli rastgele bir sayı lblRastgeleKarakterler 
        * adli label'a yazdirilacak ve kullanicidan butona bastigi anda 
        * textbox'taki yazıyla label'daki yazının karsilastirmasi yapilacak. 
        * 
        * Eger karsilastirma olumsuz ise lblKalanHakkimiz'deki deger bir azaltılacak. 
         
        Eger kullanici 5 defa hatali giris yaparsa button'un aktiflik ozelligi kapatilacak...
        
        Her hatali giriste yeni bir rastgele sayi turetilmelidir...
       */
            //999999999

            Random rnd = new Random();
           int a= rnd.Next(99999999);
            lblRastgeleKarakterler.Text = a.ToString();


        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(99999999);
            lblRastgeleKarakterler.Text = a.ToString();
            btnGirisYap.Enabled = false;
        }
    }
}
