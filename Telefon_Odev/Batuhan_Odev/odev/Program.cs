using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            telefon telefon = new telefon();
            
            

            telefon.marka = m.Samsung;
            telefon.akil = akil.Akilli;
            telefon.androİos = androios.Android;
            telefon.ram = 4;
            telefon.renk = ConsoleColor.White;
            telefon.fiyat = 1000;        
            telefon.hafiza = 64;
            telefon.ekran = 6.4;
            telefon.cozunurluk = 4800;
            telefon.batarya = 4000;
            telefon.garantisuresi = 2;


            Console.WriteLine(telefon.garantisuresi);
        }
    }
}
