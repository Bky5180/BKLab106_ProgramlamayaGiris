using System;

namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kodlar Buraya Yazilacak

            Console.WriteLine("Hello World!");
            
           //Disaridan alinan iki sayının toplamiyla farkinin birbirine
           // bolumunden kalanin sonucu kactir? (Farkın toplama bolumunden kalan kactir?)

           int s1, s2;

           Console.Write("Birinci sayıyı giriniz :");
           s1 = int.Parse(Console.ReadLine());
           Console.Write("İkinci sayıyı giriniz :");
           s2 = int.Parse(Console.ReadLine());

           int toplam = s1 + s2;
           int fark = s1 - s2;

           int sonuc = toplam % fark;
           Console.WriteLine("İşlem sonucu" + " " + sonuc);
           Console.ReadLine();

           

        }
    }

    class Deneme1
    {     
    }
    class Deneme2
    {
    }
}
