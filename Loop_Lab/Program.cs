using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string secim = "";
            do
            {

                Console.Write("1-YanYana \n2-AltAlta \n3-Kare\n4-Ucgen\n99-Çikiş\nSeçim:");
                secim =Console.ReadLine();

                    switch (secim)
                    {
                        case "1":
                            YanYanaX();
                            break;
                        case "2":
                            AltAltaX();
                            break;
                        case "3":
                            XileKare();
                            break;
                        case "4":
                            Ucgen();
                            break;
                        default:
                            break;
                    }

                Console.WriteLine("Ana Menuye Donmek icin bir tusa basiniz..");
                Console.ReadKey();
                Console.Clear();
            } while (secim!="99");
            
            
        }
        public static void XileKare()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine("");
            }
           
        }
        public static void Ucgen()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine("");
            }
           
        }

        public static void YanYanaX()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("X");
            }
            
        }

        public static void AltAltaX()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("X");
            }

        }

    }
}
