using System;
using System.Windows.Forms;

namespace TryCatchWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
             * ISTISNA TIPLERI
             * 
             * Calisma Zamani Hataları (Runtime Exception) => Cogunlukla kullanici kaynakli hatalardir. (Verinin yanlis, eksik ya da bos girilmesi). Cozum Yolu, try-catch ile hatalari ele alabilirsiniz...
             * 
             * Derleme Zamani Hatalari (Compile Exception) => Tamamen yazilimci kaynakli hatalardir. Yazim hatalari meydana geldiginde devreye girer. En kolay cozulen hata tipidir. Visual Studio sizi uyarir (asagidaki Error List penceresi ile). Ilgili hataya cift tiklayip detaya gidebilir ve hatayi aninda duzeltebilirsiniz...
             * 
             * Mantiksal Hatalar => Tamamen programci kaynakli hatalardir. Uygulamanin algoritmasinda meydana gelir. Ornegin bolme yapilacak yerde islem unutulmasi, degerin yanlis bir degerle degistirilmesi... Cozulmesi en zor hatalardir. Anlik olarak derleme asamasini takip etmeli ve degerlerinizi gozlemlemelisiniz. Bu konuda Visual Studio size sagladigi tool'larla yardimci olur. (Immediate Window, Watch, Breakpoint)
             */

        /*
         * BREAKPOINT => Derleme asamasina adim adim dahil olmak icin kullandigimiz yardimci tool'dur. Yapmaniz gereken tek sey, hangi satirdan derleme anina dahil olmak istiyorsaniz, ilgili satirin en sol kismina gelip (gri alan) mouse'un sol tusuyla bir kırmızı top yerlestirmek. Artik derleyici bu satira geldigi zaman sizi olaya dahil edecektir...
         * F11 ile adim ilerleyebilirsiniz. Degiskenlerin, nesnelerin uzerine gelip o anki degerlerini ogrenebilirsiniz, islemin bittigine inanıyorsaniz F5'e basip breakpoint'ten cikabilir ve islemin kendisini devam ettirmesini saglayabilirsiniz.
         * Sol blokta cikan sari ok, derlenen satirin isaretcisidir. Mouse yardimiyla ileri ya da geri oynatabilir yani adimlari atlayabilir ya da tekrarlatabilirsiniz...
         */

        /*
         * WATCH
         * Yalnizca run-time'da - calisma zamani - kullanabilecegimiz bir tool'dur. Dolayisiyla pencereyi sadece calisma zamaninda gorursunuz...
         * İlk ayarlarinizda Watch penceresi kapali olabilir. Uygulamanizi calistirip "CTRL+ALT+W" ardindan 1'e basarsaniz Watch penceresini getirirsiniz...
         * Run-time'de elinizde olan degerleri (kontrol degerler, degisken degerleri) degistirmenize, izlemenize olanak saglayan yardimci tool'dur. Acilan penceredeki "Name" alanina ilgili degiskenin adini yazip Enter'a basarsaniz, "Value" alaninda o anki degerini gozlemleyebilirsiniz. Hatta degistirebilirsiniz...
         * "Name" alanina degeri ilk yazmaya basladiginizda intellisense size destek vermez. Ancak "CTRL+Space" kombinasyonu ile intellisense'i aktif hale getirebilirsiniz. Hatta cogu zaman kendisi otomatik olarak tamamlar. 
         * Noktalar, virgüller, noktali virgüller - yani tum yazim kurallari - watch penceresi icin de gecerlidir...
         */

        //Eger disaridan bir veri aliyorsaniz, verinin tutarligindan emin de degilseniz, orada mutlaka hata riski vardır!

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int gelenDeger = Convert.ToInt32(txtGirisAlani.Text);
            MessageBox.Show("Tebrikler! Doğru telefon formatı girdiniz!");
        }

        private void btnHataYonetimliOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                //Bu alana hata riski olan kodlar yazilir...
                int gelen = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler! Doğru telefon formatı girdiniz!");
            }
            catch
            {
                //Try blogu icerisine yazmis oldugunuz kodlarda herhangi bir hata meydana gelirse, catch blogu devreye girer...
                MessageBox.Show("Telefon numarası yazmayı bile beceremedin!");
            }
        }

        private void btnDetayliOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int gelen = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler! Doğru formatı girdiniz!");
            }
            catch (Exception hata)
            {
                //catch ifadesinin yanindaki "Exception"ın kelime anlami => Istisna..
                //Uygulamanizin kararligini bozan istisnai durumla ilgili size detaylari teslim eden nesnedir...
                MessageBox.Show(hata.Message);  //Hata'nın sistem tarafindan atanan mesajini size teslim eder...
            }
        }

        private void btnFinallyOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int gelen = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Hata olsa da olmasa da calismasini istediginiz kodlari yazdiginiz alandir... Try-Catch-Finally uclusunde en son calisir...
                MessageBox.Show("Hata var mı yok mu bilmiyorum ama çalıştım!");
            }
        }

        private void btnHataTipleri_Click(object sender, EventArgs e)
        {
            try
            {
                int gelen = Convert.ToInt32(txtGirisAlani.Text);
            }
            catch (FormatException ex) // format hata tipi
            {
                MessageBox.Show("FormatException : " + ex.Message);
            }
            catch (DivideByZeroException ex) // sıfıra bölünme hata tipi
            {
                MessageBox.Show("DivideByZeroException : " + ex.Message);
            }
            catch (OverflowException ex) // veri tipinin boyutunu aşması durumunda alınan hata tipi
            {
                MessageBox.Show("OverflowException : " + ex.Message);
            }
            catch(Exception ex) // exception sınıfı tanımlı olan hatalar haricinde bir hata ile karşılaşılır ise, bu alandaki hata bloğu çalışacaktır
            {
                MessageBox.Show("Exception : " + ex.Message);
            }
        }
    }
}
