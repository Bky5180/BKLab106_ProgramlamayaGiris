using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declarations
            /*
             * C# içerisinde yer alan ref ve out değer türündeki verileri referans olarak metotlara geçmek için kullanılan anahtar kelimelerdir.
             * C# veri türleri temel olarak değer ve referans olmak üzere ikiye ayrılır.
             * Değer türleri (int, double, float, char .vb) belleğin stack bölgesinde tutulur.
             * Referans türleri (string, diziler, object, nesneler) belleğin heap bölgesinde tutulur.
             * Değer türleri referans türlerine göre daha hızlı çalışır ancak belleğin stack alanı sınırlı olduğu için diziler, nesneler belleğin heap bölgesinde oluşturulur.
             * Heap bölgesinde oluşturulan referans türlerine belleğin başlangıç adresi ile erişim sağlanır ve herhangi bir yerde yapılan değişiklik verinin değişmesine neden olur.
             * C# içerisinde yer alan ref ve out anahtar kelimeleri aynı işlemi yapar. Ancak ref ile kullanımda değişkene başlangıç değerinin verilmesi gerekirken out anahtar kelimesi ile kullanımda başlangıç değerinin verilmesine gerek yoktur.
             */
            #endregion

            #region DiziOrnek
            /*
                string[] kisiler = { "Yusuf Sefa", "Ramazan", "Sinan", "Mehmet" };
                foreach (string kisi in kisiler)
                    Console.WriteLine(kisi);

                Console.WriteLine();

                Duzenle(kisiler);
                foreach (string kisi in kisiler)
                    Console.WriteLine(kisi);
                */
            #endregion

            #region RefOrnek
            /*
                int sayimiz = 3;
                Console.WriteLine("Başlangıç değeri: {0}", sayimiz);
                Kare(sayimiz);
                Console.WriteLine("Kare() sonrası: {0}", sayimiz);
                Kare2(ref sayimiz);
                Console.WriteLine("Kare2() sonrası: {0}", sayimiz);
                */
            #endregion

            #region RefOutOrnek
            /*
                int sayimizOut;
                DegistirOut(out sayimizOut);
                Console.WriteLine($"DegistirOut: {sayimizOut}");

                int sayimizRef = 0;  // değer verilmediğinde hata verecektir.
                DegistirRef(ref sayimizRef);
                Console.WriteLine($"DegistirRef: {sayimizRef}");
                */
            #endregion

            #region OutTryParseOrnek
            /*
            string girilenSayi = "1453";
            int sayimiz;

            bool sonuc = int.TryParse(girilenSayi, out sayimiz);

            if (sonuc)
            {
                Console.WriteLine("Dönüşüm başarılı.");
                Console.WriteLine("Sayı: {0}", sayimiz);
            }
            else
            {
                Console.WriteLine("Dönüşüm başarısız.");
                Console.WriteLine("Sayı: {0}", sayimiz);
            }
            */
            #endregion

            Console.ReadKey();
        }
        static void Duzenle(string[] kisiler)
        {
            for (int i = 0, kisiSayisi = kisiler.Length; i < kisiSayisi; i++)
                kisiler[i] = "Yusuf";
        }
        static void Kare(int sayi)
        {
            sayi = sayi * sayi;
        }
        static void Kare2(ref int sayi)
        {
            sayi = sayi * sayi;
        }
        static void DegistirOut(out int sayiOut)
        {
            sayiOut = 1234;
        }
        static void DegistirRef(ref int sayiRef)
        {
            sayiRef = 5678;
        }
    }
}
