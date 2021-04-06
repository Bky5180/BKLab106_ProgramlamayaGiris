using System;
using System.Collections.Generic;
using System.Text;

namespace Kutuphane
{
    public class OnurOdev
    {
        //Soru 1
        /// <summary>
        /// Decimal'de bile ay değeri en fazla 94 girilebiliyor. Fazlası Exception veriyor.
        /// </summary>
        /// <returns>Decimal tipinden</returns>

        /*
        Odev : Bir cift Tavsanimiz var . Bu tavsanlar yavrudur.
           Yavru tavsanlar bir ay icerisinde ergenlige ulasmaktadir.
           Ergenlesen her cift tavsan bir ay sonra bir cift tavsan dogurmaktadir.
           Bu matematige gore de tavsanlar ölümsüzdür.
           100 ay  sonra kac tavsanim olur ?     
    */
      //  1 ,1 ,2 ,3 ,5 ,8 ,13 ,21,34,55

        public decimal Sayim()
        {
            decimal dogumSayisi = 1, toplamTavsan = 2;
            try
            {
                do
                {
                    Console.Clear();
                    Console.Write("Ay sayısı giriniz: ");
                    bool kontrol = uint.TryParse(Console.ReadLine(), out uint ay);

                    if (kontrol && ay != 0)
                    {
                        for (int i = 1; i <= ay; i++)
                        {
                            dogumSayisi *= 2;
                            toplamTavsan += dogumSayisi;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nAy değeri sayısal ve en az 1 olmalıdır!");
                        Console.WriteLine("Tekrar denemek için bir tuşa basınız...");
                        Console.ReadKey();
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError Message: " + ex.Message);
            }
            return toplamTavsan;
        }

        //Soru 2
        /// <summary>
        /// Küçükten büyüğe sıralama yapan metot
        /// </summary>
        public void Siralama()
        {
            int[] sayilar = new int[3];
            int uzunluk = sayilar.Length;
            int gecici;

            for (int i = 0; i < uzunluk; i++)
            {
                Console.WriteLine("Bir sayı giriniz: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < uzunluk; i++)
            {
                for (int j = 0; j < uzunluk - i - 1; j++)
                {
                    if (sayilar[j] > sayilar[j + 1])
                    {
                        gecici = sayilar[j];
                        sayilar[j] = sayilar[j + 1];
                        sayilar[j + 1] = gecici;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < uzunluk; i++)
            {
                Console.Write($"{sayilar[i]} ");
            }
        }
    }
}
