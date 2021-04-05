using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane;
namespace MathLib
{
    class Program
    {
        static void Main(string[] args)
        {

            //PiSayisi();
            //Max();
            //Min();
            //Ustalma(5,3);
            GenelMetodlar genel = new GenelMetodlar();
         
            Console.WriteLine("Usat alma 2.5=>2. Kuvveti:"+genel.UstAlma(2.5, 2));

            Console.WriteLine($"-5 sayisini Mutlak Degeri:{genel.MutlakDeger(-5)}");

            Console.WriteLine("12.98'in asagi yuvarlanmis hali:" +genel.AsagiYuvarla(12.98));

            Console.WriteLine("12.12'in Yukari yuvarlanmis hali:" + genel.YukariYuvarla(12.12));

            Console.WriteLine($"12.5 sayisini yuvarlanmis hali:{genel.Yuvarla(12.5)}");

            Console.WriteLine($"-12.5 sayisini yuvarlanmis hali:{genel.OndalikTemizle(-12.5)}");
            //Disaridan girilen 3 sayidan en kucugunu tek satirda gosteriniz...

            Console.WriteLine($"5,9,7 sayilarinin en Kucugu  {Math.Min(Math.Min(5,9),7) }");

            double sayi=15;
            //Console.WriteLine("Ust alma 2=>2. Kuvveti:" + genel.UstAlma(2, out sayi));
            //Console.WriteLine("Ust alma 2=>3. Kuvveti:" + sayi);

            //Console.WriteLine("Ref :" + genel.refDeneme(2,ref sayi));

            //Console.WriteLine("Toplam :"+ genel.topla(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7));

            Console.WriteLine("Out Oncesi :"+sayi);

            //Console.WriteLine("Out Sonrasi :" + TestOut(out sayi));

            int sayi1, sayi2;
            int toplam, fark, carpim;
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
           
            sayi1 = 5;
            sayi2 = 6;
            TestOut(sayi1,sayi2,out toplam ,out fark,out carpim );
            Testref(sayilar);
            Testref2( sayi1);
        }
        public static void Testref(int[] sayilar)
        {

            sayilar = new int[]{ 45,65,98,78};
            sayilar[0] = 321;
            

            

        }
        private static void Testref2( int sayi1)
        {
            sayi1 = 55;
        }

        public static void TestOut(int a ,int b ,out int  toplam,out int fark,out int carpim)
        {

            toplam = a + b;
            fark = a - b;
            carpim = a * b;
            
        }
       

        // Metodlarda gelen parametreleri karsilayacak sekilde tiplerini belirtecegimiz degiskenler olmalidir


        private static void Min()
        {
            throw new NotImplementedException();
        }

        private static void Max()
        {
            throw new NotImplementedException();
        }

        private static void PiSayisi()
        {
            Console.WriteLine(Math.PI.ToString());
        }
    }
}
