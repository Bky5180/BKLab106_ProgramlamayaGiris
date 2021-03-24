using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           
           //Disaridan alinan iki sayının toplamiyla farkinin birbirine
           // bolumunden kalanin sonucu kactir? (Farkın toplama bolumunden kalan kactir?)

            int      s1, s2,toplam,fark;
            string   str1, str2;
            DateTime date;
            decimal d1;
            float f1;
            double db1;
            bool lg;
            char ch;
            // 1. Sayiyiyi Oku
            Console.Write("Birinci sayıyı giriniz :");
            s1 = int.Parse(Console.ReadLine());


            // 2. Sayiyiyi Oku
            Console.Write("İkinci sayıyı giriniz :");
           s2 = int.Parse(Console.ReadLine());




            ////1. cevirme yontemi
            //s1 = int.Parse(str1);
            
            ////2. cevirme yontemi
            //s1 = Convert.ToInt32(str1);
            

            ////2. Sayiyi int'e cevir
            //s2 = int.Parse(str2);


            // 
            // Topla
            toplam = s1 / s2;
            
            // Cikar
            fark = s1 - s2;

            // Kalan 'i bulur
           int sonuc = toplam % fark;
           Console.WriteLine("İşlem sonucu" + " " + sonuc);
           Console.ReadLine();

           

        }
    }
}
