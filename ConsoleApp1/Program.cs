using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane;
namespace ConsoleApp1
{
   
    class Program
    {

        static string stringOku()
        {
            string str = "";
            str = Console.ReadLine();

            return str;
        }
        static int SayiOku()
        {
            // 1. Sayiyiyi Oku
            int s1 = 0;
            string str = "";
            try
            {
                Console.Write("Sayı giriniz :");
                str = Console.ReadLine();
                s1 = int.Parse(str);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Duzgun bir sayi giriniz.");
            }


            return -5;
        }
        static void Deneme1()
        {

            //Disaridan alinan iki sayının toplamiyla farkinin birbirine
            // bolumunden kalanin sonucu kactir? (Farkın toplama bolumunden kalan kactir?)
            int s1, s2, toplam, fark;
            string str1, str2;
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

        // 1,1,2,3,5,8,13
        static void Main(string[] args)
        {

          
            
            int boyut = 0;
            GenelMetodlar genel = new GenelMetodlar();

            // genel.Fibanocci(200);
            genel.fibanocciDizi();

            //boyut = genel.EkrandanSayiOku("Fibonacci Dizisinin Üst Limitini Giriniz: ");

            //Deneme1();

            //int a = 0;
            //string str;
            //a = SayiOku();
            //str = stringOku();

            //// Ekrana basma Yontemleri
            //// 1. Yontem
            //Console.WriteLine("Gelen String: " + str);
            //// 2.Yontem  C dilindeki yapinin aynisi.
            //Console.WriteLine("Gelen String:{0}  Gelen int :{1}", str, a);
            //// 3. Yontem
            //Console.WriteLine($"Gelen String:{str}  Gelen int :{a}");


            Console.ReadKey();


        }
    }
}
