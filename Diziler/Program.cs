using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane;
namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanimi [] ile tanimlanir. 
            // Diziler Referans tiptedir. 
            // Dizilerin boyutlari sonradan degistirilemez
            // diziler index olarak 0'dan başlar !!!!!
            // 

            // ornek
            int[] yas = new int[12]; // Hafiza da Heap bolgesinde yer tutar
                                     // Lisedeki dersler dizisi
                                     //1. yontem Instance alarak belirlemek
                                     //string[] dersler = new string[10];
                                     //dersler[0] = "Matematik";
                                     //dersler[1] = "Fizik";
                                     ////dersler[2] = "Kimya";
                                     //dersler[3] = "Edebiyat";
                                     //dersler[4] = "Biyoloji";
                                     //dersler[5] = "Muzik";
                                     //dersler[6] = "Beden";
                                     //dersler[7] = "Felsefe";
                                     //dersler[8] = "Cografya";
                                     //dersler[9] = "Ingilizce";
                                     //dersler[10] = "Almanca";
                                     //dersler[11] = "Bilisim Teknolojileri";
                                     //dersler[12] = "Tarih";
                                     // 1. Yontem for ile 
                                     //int boyut = dersler.Length;
                                     //for (int i = 0; i < boyut; i++)
                                     //{
                                     //    Console.WriteLine(dersler[i]);
                                     //}

            // 2. Yontem for ile 
            //foreach (var item in dersler)
            //{
            //    Console.WriteLine(item);

            //}

            // 2. Tanimlama yontemi 
            // dizi instance alinirken ilk deger atamasi seklinde yapilir

            //int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // 3. Tanimlama yontemi

            //int[] sayilar2 = { 9, 5, 6, 7, 3 };

            // Eleman okuma yontemi : index ile olur 
            //Console.WriteLine(sayilar[3]); // 4 Yazacaktir.
            //Cevap1();
            // Ekrandan alinacak 10 adet sayinin karesini ve kupunu ekrana bastirin
            // Ciktisi ...
            // Sayi   Karesi    Kup
            // ----   ------    ----
            //  4       16      64
            //  2       4       8

            //CarpimTaplosu();

            // Soru 2 : Carpim tapolusunu ekrana bastirin
            //  1 x 1 = 1
            //  1 x 2 = 2


            // Soru 3: Klavyeden girilen sayini faktoryelini hesaplayin
            //ForeachEkrandanOkuyamama();
            //Faktoryel();

            #region Kutuphane Kullanimi
            GenelMetodlar metodlar = new GenelMetodlar();

            int sayi = metodlar.EkrandanSayiOku();

            metodlar.Faktoryel(sayi);

            #endregion


            #region Static Kutuphane Kullanimi

            metodlar.CarpimTaplosu();

            #endregion
            //SonsuzDongu();

            Console.ReadLine();
        }

        public static void SonsuzDongu()
        {
            int a = 0;
            do
            {
                a++;
                Console.WriteLine(a);
                if (a == 100)
                {
                    break;
                }

            } while (true);
            
        }
        public static void ForeachEkrandanOkuyamama()
        {
            int[] sayilar = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};
            foreach (var item in sayilar)
            {
                
                Console.WriteLine(item); //= int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = 5;
            }


        }
        public static void Cevap1()
        {


            int[] dizi1 = new int[10];

            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sayi\tKaresi\tKup");
            for (int i = 0; i < dizi1.Length; i++)
            {
                Console.WriteLine($"{dizi1[i]}\t{dizi1[i] * dizi1[i]}\t{dizi1[i] * dizi1[i] * dizi1[i]}");
            }

        }
        public static void CarpimTaplosu()
        {
            //Ceren Sahin Cozumu

            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0}*{1}={2}\t", i, j, (i * j));
                }
                Console.WriteLine();
            }

        }
        public static void Faktoryel(int sayi)
        {
            // Teoman Yanmaz Cozumu

            ulong faktoriyel = 1;
            //int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = sayi; i > 0; i--)
            {
                faktoriyel = (ulong)i * faktoriyel;
            }
            Console.WriteLine(faktoriyel);
        }
    }
}
