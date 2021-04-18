using System;

namespace BasamakSayisiBulma
{
    class Program
    {
        static byte sayac;
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                bool kontrol;
                do
                {
                    Console.Clear();
                    Console.Write("Bir sayı giriniz: ");
                    kontrol = decimal.TryParse(Console.ReadLine(), out decimal sayi);

                    if (!kontrol)
                    {
                        Console.WriteLine("\nEksik ya da yanlış giriş yaptınız." +
                            "\nTekrar giriş için bir tuşa basınız.");
                        Console.ReadKey();
                    }
                    else
                    {
                        sayac = 0;
                        Console.WriteLine($"\n{string.Format("{0:0,0}", sayi)} " +
                            $"sayısının basamak sayısı: {Hesapla(sayi)}");
                    }
                } while (!kontrol);

                Console.Write("\nTekrar denemek ister misiniz? [E/H]: ");
                keyInfo = Console.ReadKey();

            } while (keyInfo.Key == ConsoleKey.E);
        }
        static byte Hesapla(decimal sayi)
        {
            decimal bolum;
            if (sayi == 0)
                return 1;

            bolum = sayi / 10;
            if (Math.Abs(bolum) < 10 && Math.Abs(sayi) < 10)
                sayac++;
            else
            {
                ++sayac;
                Hesapla(bolum);
            }
            return sayac;
        }
    }
}
