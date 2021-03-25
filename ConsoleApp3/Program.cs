using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            DateTime trh = Convert.ToDateTime("2020/12/24");

            Int64 sayi = 100000000;
            Int16 sayi2 = (Int16)sayi; // 57600

            //TipDonusum();
            TarihTipDonusum();
            //1110 1000
            //101 1111 0101 1110 0001 0000 0000
            //101 1111 0101 1110 0001 0000 0000
            Console.WriteLine(sayi2.ToString());
            Console.WriteLine(sayi.ToString());
        }

        public static void TarihTipDonusum()
        {
            Console.WriteLine(Convert.ToDateTime("12/24/2020")); // Format mm/dd/yyyy kabul eder
            Console.WriteLine(Convert.ToDateTime("12-24-2020")); 
            Console.WriteLine(Convert.ToDateTime("12,24,2020"));
            Console.WriteLine(Convert.ToDateTime("12.24.2020")); // 
            Console.WriteLine(Convert.ToDateTime("12 24 2020")); // Bosluk Kabul Eder
            //Console.WriteLine(Convert.ToDateTime("12;24;2020")); // Gecersiz format
            Console.WriteLine(Convert.ToDateTime("24/12/2020")); // Gecersiz Format dd/ mm / yyyy

            
        }

        public static void TipDonusum()
        {

            //Bir veri tipindeki degiskeni, diger bir veri tipine cevirmek icin ihtiyacimiz olan yardimci bir sinif vardir. Bu sınıf "Convert" sınıfıdır...
            //Burada bir istisnadan bahsetmekte fayda var: Dis dunyaya gosterilecek olan ne varsa, bu degerler mutlak suretle metinsel - string veri tipi - olmalidir. Dolayisiyla bir degeri string'e cevirmek icin .NET bize bir kolaylik sunmustur...
            int sayi = 23;
            //Unutulmamasi gereken bir nokta, veriyi string'e cevirdigimiz anda, uzerindeki matematiksel fonksiyonlarini kaybeder!
           Console.WriteLine(sayi.ToString());

            string cevrilecekDeger = "12301230123";
            int cevrilmisBir = Convert.ToInt32(cevrilecekDeger); // 123 Convert.ToInt32 => int'e cevirme islemi...
            byte cevrilmisIki = Convert.ToByte(cevrilecekDeger); // 123 Convert.ToByte => byte'e cevirme islemi...
            short cevrilmisUc = Convert.ToInt16(cevrilecekDeger);// 123 Convert.ToInt16 => short'a cevirme islemi...
            long cevrilmisDort = Convert.ToInt64(cevrilecekDeger);// 123 Convert.ToInt64 => long'a cevirme islemi...

            float cevrilmisBes = Convert.ToSingle(cevrilecekDeger);//123 Convert.ToSingle => float'a cevirme islemi...

            bool sonuc = true;

        }
    }
}
