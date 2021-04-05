using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane
{    /*
     Odev : Bir cift Tavsanimiz var . Bu tavsanlar yavrudur.
            Yavru tavsanlar bir ay icerisinde ergenlige ulasmaktadir.
            Ergenlesen her cift tavsan bir ay sonra bir cift tavsan dogurmaktadir.
            Bu matematige gore de tavsanlar ölümsüzdür.
            100 ay  sonra kac tavsanim olur ?     
     */
    /*     
     Odev : Ekrandan alinacak 3 adet sayiyi kucukten buyuge dogru siralayin     
     */
    /*     
     8 veziri satranc tahtasina birbirini yemeyecek sekilde diziniz.
     Programini yapmayin. Sadece tahtada calisin
     */



    
    public static class GenelStaticMetodlar
    {
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
        public static int EkrandanSayiOku()
        {
            int sayi = 0;
            string str = "";
            Console.Write("Bir Sayi Giriniz:");
            try
            {
                do
                {
                    str = Console.ReadLine();
                    bool donustumu = int.TryParse(str, out sayi);
                    if (donustumu)
                    {
                        break;
                    }
                    Console.WriteLine("Lutfen Sayi Giriniz...");
                } while (true);
            }
            catch (Exception)
            {
                throw;
            }
            return sayi;
        }
    }

    /// <summary>
    /// Genel anlamada hosumuza giden metodlari topladigimiz kutuphane
    /// </summary>
    public class GenelMetodlar
    {
         int abc;
        /// <summary>
        /// Verilen sayiya kadar olan fibanocci sayilarini ekrana basar
        /// </summary>
        /// <param name="sayiAdet"></param>
        public void Fibanocci(int sayiAdet)
        {
            decimal birinciSayi = 0;
            decimal ikinciSayi = 1;
            decimal temp;
            for (int i = 0; i < sayiAdet; i++)
            {
                Console.WriteLine($"{i}.Sayi: {birinciSayi}");
                temp = ikinciSayi;
                ikinciSayi = birinciSayi + ikinciSayi;
                birinciSayi = temp;
                if (i < sayiAdet - 1)
                    Console.Write(",");
            }

        }

        public void fibanocciDizi()
        {
            // Dizinin boyutunu ve tipini belirleyelim .


            int boyut = EkrandanSayiOku();


            // ULong tipinden ekrandan alinan sayi boyutunda bir dizi olusturur

            ulong[] fibanocci = new ulong[boyut];
            for (int i = 0; i < boyut; i++)
            {
                //Sifira Esitse 
                if (i == 0)
                {
                    fibanocci[i] = 0;
                }
                else if (i == 1)
                {
                    fibanocci[i] = 1;
                }
                else // Birden buyukse
                {
                    fibanocci[i] = fibanocci[i - 1] + fibanocci[i - 2];
                }
                if (i >= 2)
                    Console.WriteLine($"fibanocci[{i + 1}]:{fibanocci[i]} ==> {(float)fibanocci[i] / fibanocci[i - 1]}");
            }


        }

        /// <summary>
        /// Carpim tablosunu Console da gosterir
        /// </summary>
        public void CarpimTaplosu()
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
        void test()
        {


        }
        /// <summary>
        /// Verilen sayinin faktoryelini  hesaplar
        /// </summary>
        /// <param name="sayi">integer tipinden olmalidir</param>
        /// <returns>ulong tipinden </returns>
        public ulong Faktoryel(int sayi)
        {
            // Teoman Yanmaz Cozumu

            ulong faktoriyel = 1;
            //int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = sayi; i > 0; i--)
            {
                faktoriyel = (ulong)i * faktoriyel;
            }
            //Console.WriteLine(faktoriyel);
            return faktoriyel;
        }
        public int EkrandanSayiOku()
        {
            int sayi = 0;
            string str = "";
            Console.Write("Bir Sayi Giriniz:");
            try
            {
                do
                {
                    str = Console.ReadLine();
                    bool donustumu = int.TryParse(str, out sayi);
                    if (donustumu)
                    {
                        break;
                    }
                    Console.WriteLine("Lutfen Sayi Giriniz...");
                } while (true);
            }
            catch (Exception)
            {
                throw;
            }
            return sayi;
        }
        public int EkrandanSayiOku(string ifade)
        {
            int sayi = 0;
            string str = "";
            Console.Write(ifade);
            try
            {
                do
                {
                    str = Console.ReadLine();
                    bool donustumu = int.TryParse(str, out sayi);
                    if (donustumu)
                    {
                        break;
                    }
                    Console.WriteLine("Lutfen Sayi Giriniz...");
                } while (true);
            }
            catch (Exception)
            {
                throw;
            }
            return sayi;
        }
        public long EkrandanSayiOku(string ifade, int deger)
        {
            int sayi = 0;
            string str = "";
            Console.Write(ifade);
            try
            {
                do
                {
                    str = Console.ReadLine();
                    bool donustumu = int.TryParse(str, out sayi);
                    if (donustumu)
                    {
                        break;
                    }
                    Console.WriteLine("Lutfen Sayi Giriniz...");
                } while (true);
            }
            catch (Exception)
            {
                throw;
            }
            return sayi;
        }

        /// <summary>
        /// Bu metod verilen sayinin verilen ust'unu alir
        /// </summary>
        /// <param name="sayi">ust'u alinacak sayi</param>
        /// <param name="ust">kacinci kuvveti oldugunu belirtir</param>
        /// <returns></returns>
        public double UstAlma(double sayi, double ust)
        {
            return Math.Pow(sayi, ust);
        }
       

        public double UstAlma(int sayi, int ust)
        {
            
                int abc;
           
           
            return Math.Pow(sayi, ust);
        }
        public double UstAlma(float sayi, float ust)
        {
            return Math.Pow(sayi, ust);
        }
        public double UstAlma(long sayi, long ust)
        {
            return Math.Pow(sayi, ust);
        }

       public int MutlakDeger(int sayi)
        {

            return Math.Abs(sayi);
        }

        public double UstAlma(int sayi,out double sayi2 )
        {

            sayi2 = Math.Pow(sayi, 3);

            return Math.Pow(sayi, 2);

            
        }


        public double refDeneme(int sayi, ref double sayi2)
        {


            sayi2 = Math.Pow(sayi, 4);
            return Math.Pow(sayi,2);
        }

        public int topla(int a, int b)
        {
            return a + b;
        }
        public int topla(int a, int b,int c)
        {
            return a + b+c;
        }
        public int topla(int a, int b, int c,int d)
        {
            return a + b + c+d;
        }
        public int topla(params int[] sayi )
        {
            int toplam = 0;
            for (int i = 0; i < sayi.Length; i++)
            {
                toplam += sayi[i];
            }
            return toplam;
        }

        public double AsagiYuvarla(double sayi)
        {
            //Floor => Verilen ondalikli degeri, bir alt tam degere tamamlar...
            return Math.Floor(sayi);

        }
        /// <summary>
        /// Ceiling => Verilen ondalikli degeri, bir ust tam degere tamamlar...
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        public double YukariYuvarla(double sayi)
        {
           
            return  Math.Ceiling(sayi);
        }
        /// <summary>
        /// Round => Sayinin yarisindan fazlasini bir uste, yarisindan azini ise bir alttaki tam sayiya yuvarlar...
        ///
        /// NOT : .'dan önceki sayı çift ise bir alt değere, tek ise bir üst değere tamamlar. (NOT: .'dan sonraki değer 50 ise)
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        public double Yuvarla(double sayi)
        {
            


            return Math.Round(sayi);

        }
        /// <summary>
        /// Truncate => Sayının ondalikli kismina bakmaz, yalnizca tam kismini size teslim eder...
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        public double OndalikTemizle(double sayi)
        {
            //
           return Math.Truncate(sayi);

        }
        /// <summary>
        /// Sqrt => Bir sayının karekokunu hesaplamak icin kullanilir...
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        public double KareKok(double sayi)
        {
            return Math.Sqrt(sayi);
        }



        /// <summary>
        ///  SIGN => Bir sayinin negatif, pozitif ya da 0'a esit olup olmadigiyla ilgili bildirim doner...
        //    Eger sayi negatifse -1, pozitifse +1, 0 ise size 0 degerini doner...
        /// </summary>
        /// <param name="sayi"></param>
        /// <returns></returns>
        public int SayiIsareti(double sayi)
        {

            return Math.Sign(sayi);
        
        }

    }
    //public class OnurOdev
    //{
    //    //Soru 1
    //    /// <summary>
    //    /// Decimal'de bile ay değeri en fazla 94 girilebiliyor. Fazlası Exception veriyor.
    //    /// </summary>
    //    /// <returns>Decimal tipinden</returns>
    //    public decimal Sayim()
    //    {
    //        decimal dogumSayisi = 1, toplamTavsan = 2;
    //        try
    //        {
    //            do
    //            {
    //                Console.Clear();
    //                Console.Write("Ay sayısı giriniz: ");
    //                bool kontrol = uint.TryParse(Console.ReadLine(), out uint ay);

    //                if (kontrol && ay != 0)
    //                {
    //                    for (int i = 1; i <= ay; i++)
    //                    {
    //                        dogumSayisi *= 2;
    //                        toplamTavsan += dogumSayisi;
    //                    }
    //                    break;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("\nAy değeri sayısal ve en az 1 olmalıdır!");
    //                    Console.WriteLine("Tekrar denemek için bir tuşa basınız...");
    //                    Console.ReadKey();
    //                }
    //            } while (true);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("\nError Message: " + ex.Message);
    //        }
    //        return toplamTavsan;
    //    }

    //    //Soru 2
    //    /// <summary>
    //    /// Küçükten büyüğe sıralama yapan metot
    //    /// </summary>
    //    public void Siralama()
    //    {
    //        int[] sayilar = new int[3];
    //        int uzunluk = sayilar.Length;
    //        int gecici;

    //        for (int i = 0; i < uzunluk; i++)
    //        {
    //            Console.WriteLine("Bir sayı giriniz: ");
    //            sayilar[i] = int.Parse(Console.ReadLine());
    //        }

    //        for (int i = 0; i < uzunluk; i++)
    //        {
    //            for (int j = 0; j < uzunluk - i - 1; j++)
    //            {
    //                if (sayilar[j] > sayilar[j + 1])
    //                {
    //                    gecici = sayilar[j];
    //                    sayilar[j] = sayilar[j + 1];
    //                    sayilar[j + 1] = gecici;
    //                }
    //            }
    //        }
    //        Console.WriteLine();
    //        for (int i = 0; i < uzunluk; i++)
    //        {
    //            Console.Write($"{sayilar[i]} ");
    //        }
    //    }
    //}
}