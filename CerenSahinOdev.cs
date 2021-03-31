using System;

namespace CerenKutuphane
{
    public class CerenSahinOdev
    {
        public static void Fibonacci()
        {
            /* Odev: Bir çift Tavşanımız var. Bu tavsanlar yavrudur.
            Yavru tavsanlar ergenlige bir ay icerisinde ulasmaktadir.
            Ergenlesen çiftini tavsan bir ay sonra bir cift tavsan dogurmaktadir.
            Bu matematige gore de tavsanlar ölümsüzdür.
            100 ay sonra kac tavsanim olur ?
            */

            decimal a = 1;
            decimal b = 1;


            Console.Write(a + " " + b + " ");
            for (decimal i = 3; i <= 100; i++)
            {
                decimal c = a + b;
                Console.Write(c + " ");

                a = b;
                b = c;
            }

        }
        public static void BuyuktenKucugeSiralama()
        {
            // Odev: Ekrandan alinacak 3 adet sayiyi kucukten buyuge dogru siralayin
            int[] sayilar = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Lütfen bir sayı giriniz=");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Küçükten büyüğe doğru sıralama");
            Array.Sort(sayilar);

            foreach (int i in sayilar)
            {

                Console.WriteLine("{0}", i);
            }
        }


    }
}
