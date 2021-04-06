using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //IkiyeBolunenler();
            ArrayKullanimi();

        }

        public static void IkiyeBolunenler()
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 55, 66, 78, 98, 15, 32, 46 };

            foreach (int  sayi in sayilar)
            {
                if(sayi%2==0)
                Console.WriteLine(sayi);
            }
        }

        public static void ArrayKullanimi()
        {
            int[] sayilar = { 55, 66, 78, 98, 15, 32, 46 };
            string[] sehirler = { "Mus", "Adana", "Izmir", "Edirne", "Van" };
            string[] sehirler2 = { "Ankara", "Istanbul"};
            Console.WriteLine("Siralanmadan Onceki Hali");
            //foreach (int sayi in sayilar)
            //{

            //        Console.WriteLine(sayi);
            //}

            //Array.Sort(sayilar);

            //Console.WriteLine("Siralandiktan Sonraki Hali");
            //foreach (int sayi in sayilar)
            //{

            //    Console.WriteLine(sayi);
            //}

            //foreach (var item in sehirler)
            //{

            //    Console.WriteLine(item);
            //}

            //Array.Sort(sehirler);

            //Console.WriteLine("Siralandiktan Sonraki Hali");
            //foreach (var item in sehirler)
            //{

            //    Console.WriteLine(item);
            //}

            // Clear Metodu
            //Array.Clear(sehirler,1,2);

            //foreach (var item in sehirler)
            //{

            //    Console.WriteLine(item);
            //}


            //Copy Metodu : 1. Parametre kaynak dizi,2.  ise hedef dizi ,3. Paramtre kac adet kopyalanacak
            //Array.Copy(sehirler2, sehirler, 2);
            //foreach (var item in sehirler)
            //{

            //    Console.WriteLine(item);
            //}


            // Resize :Dizinin Boyutunu degistirir

            //Array.Resize(ref sehirler, 10);
            //foreach (var item in sehirler)
            //{

            //    Console.WriteLine(item);
            //}


            //Reverse 
            //Array.Reverse(sehirler);
            //foreach (var item in sehirler)
            //{

            //    Console.WriteLine(item);
            //}

            //clone
            string[]  yeniSehirler =(string[])sehirler.Clone();

            object a = new object();
            

            //foreach (var item in yeniSehirler)
            //{

            //    Console.WriteLine(item);
            //}


            //IndexOf : aranan degerin indexini doner . Bulamaz ise -1 doner
            //int edirneIndex = Array.IndexOf(sehirler, "Edirne2");

            //Console.WriteLine(edirneIndex);
        }
    }
}
