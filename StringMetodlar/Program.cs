using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string metin = "Son iki yildir pandemi ve covid19 ile ugrasiyoruz. Bir an once bitsede kurtulsak . Normal hayat nede guzelmiş. Hafta sonlari ne guzel gezip tozuyorduk";

            //Contains : Degisken icinde aranan kelime varmi yokmu . Sorgulama sonucunu true yada flase olarak döndürür.
            bool varmiyokmu = metin.Contains("covid19");
            ConsoleKeyInfo key;


            #region StartWith EndWith
            //varmiyokmu = metin.StartsWith("Son");
            //Console.WriteLine(varmiyokmu);

            //varmiyokmu = metin.StartsWith("Son");
            //Console.WriteLine(varmiyokmu);

            //varmiyokmu = metin.StartsWith("So");
            //Console.WriteLine(varmiyokmu);

            //varmiyokmu = metin.EndsWith("Son");
            //Console.WriteLine(varmiyokmu);

            //varmiyokmu = metin.EndsWith("duk");
            //Console.WriteLine(varmiyokmu);

            #endregion


            #region CompareTo
            //CompareTo => Metodu kullandiginiz string degerle metoda verdiginiz parametredeki string degeri sozluk mantigiyla karsilastirir... Eger sozlukte ayni lokasyonlardasa 0, parametredeki deger, ana degerimizden sozlukte onceyse -1; sonraysa 1 degerini dondurur...
            string kelime = "Bakirkoy ";
            //string kelime = "Bakirkoy";
            //string kelime = "Bakir";
            int sonuc = kelime.CompareTo("Bakirkoy Sube");

            //string mesaj = "";
            //switch (sonuc)
            //{
            //    case -1:
            //        mesaj = "Kelime diğer kelime ile eşleşmeketedir. Eksik karakter var";
            //        break;
            //    case 0:
            //        mesaj = "Tebrikler! Kelimeler eşleşmektedir";
            //        break;
            //    case 1:
            //        mesaj = "Kelime diğer kelime ile eşleşmemektedir. Fazla karakter var";
            //        break;
            //    default:
            //        break;
            //}


            #endregion

            #region IndexOf
            //IndexOf => Dizilerde gordugumuz metodun ayni prensibleriyle calisir. Eger harf varsa harfin indexini, yoksa -1 degerini, harf birden fazla var ise ilk harfin indexini dondurur...
            //string ornekMetin = "Dizilerde gordugumuz metodun agni";
            //int index = ornekMetin.IndexOf('g');

            //Console.WriteLine(index);
            #endregion


            #region LastIndexOf
            // LastIndexOf => Dizilerde gordugumuz metodun ayni prensibiyle calisir. Eger harf varsa harfin indexini, yoksa - 1 degerini, harf birden fazla varsa son harfin indexini dondurur...


            //string ornekMetin = "Dizilerde gordugumuz metodun agni";
            //int index = ornekMetin.LastIndexOf('g');

            //Console.WriteLine(index);


            #endregion


            #region Remove
            //NOT => Bir string uzerinde yaptiginiz degisiklikler o string'i degistirmez, size yeni bir kopyasini teslim eder...
            //Remove (1.Kullanım) => Verdiginiz index numarasi dahil, o indexteki ve sonraki tum karakterleri ortadan kaldirir...
            //Remove (2.Kullanım) => Verdiginiz index numarasi dahil, o indexteki elemandan baslayarak, ikinci parametrede gonderdiginiz deger kadar eleman siler...

            //string ornekMetin = "Dizilerde gordugumuz metodun ayni";
            //string OrnekMetin = ornekMetin.Remove(9);            // => BİRİNCİ KULLANIM
            //ornekMetin = ornekMetin.Remove(3, 4);         // => İKİNCİ KULLANIM




            #endregion


            #region Replace
            //Replace => Metniniz icerisindeki bir karakteri ya da bir bolumu yeni bir karakter - bolum - ile degistirmenize olanak saglar..
            string ornekMetin = "Dizilerde gordugumuz metodun ayni";
            string str = ornekMetin.Replace("metodun", "ayni metod");
            #endregion

            #region Split
            //Split => Metninizi ozel bir karakterden birden fazla parcaya ayirmaniza olanak saglayan metottur. Ayni anda birden fazla ozel karakter de verebilirsiniz...
            //string mailadresleri = "ali@hotmail.com;ali@gmail.com;veli@yahoo.com";

            //string[] adresler = mailadresleri.Split(';');
            //foreach (var item in adresler)
            //{

            //    Console.WriteLine(item);
            //    //string[] domain = item.Split('@');
            //    //Console.WriteLine(domain[0]);
            //    //Console.WriteLine(domain[1]);

            //    //string[] firma = domain[1].Split('.');
            //    //Console.WriteLine(firma[0]);

            //    Console.WriteLine(item.Split('@')[1].Split('.')[0]);
            //    Console.WriteLine("------------------");

            //}

            // Kullanilan mail firmalari hangileridir ?
            // Hotmail
            // gmail
            // yahoo

            // Sadece Veliyi Bulalim

            //Console.WriteLine(mailadresleri.Split(';')[2].Split('@')[0]);
            #endregion


            #region Insert
            //Insert => Bir metinsel degerin herhangi bir pozisyonuna (index) yeni bir degeri ilistirmek istiyorsaniz bu metodu kullanabilirsiniz. İlk parameterde kacinci indexten sonra ekleyecegini, ikinci parametrede ise hangi metni ekleyecegini sorar...
            //string temp = "Bilge Adam Bakirkoy Subesi";
            //string temp2  = temp.Insert(5, "Test");
            //Console.WriteLine(temp2);
            #endregion

            #region Substring
            //Substring (1.Kullanım) => Metninizden, parametrede gonderdiginiz indexten baslayarak, geri kalan kismi cekip almaniza olanak saglar...
            //Substring (2.Kullanım) => Metninizden, ilk parametrede verdiginiz indexten baslayip, ikinci parametrede verdiginiz deger kadarlik kismi cekip almaniza olanak saglar..
            //Console.WriteLine(metin.Substring(10, 10));
            //Console.WriteLine(metin.Substring(10));


            #endregion

            #region ToCharArray
            //ToCharArray => Stringinizi charlarina ayirarak size char[] olarak teslim eder...
            //ornekMetin = "Stringinizi charlarina ayirarak size char[] olarak teslim eder";
            //char[] karakterler = ornekMetin.ToCharArray();

            ////ORNEK: disaridan girilen metindeki her bir karakterin ASCII degerleri toplami kactir?
            //int havuz = 0;
            //for (int index = 0; index < karakterler.Length; index++)
            //{
            //    havuz += karakterler[index];
            //    Console.WriteLine(karakterler[index]);
            //}

            #endregion


            #region Trim
            //Trim => Metninizin saginda ya da solundaki tum bosluklari temizlemenize olanak saglayan metottur...
            //ornekMetin = "             String               ";
            //Console.WriteLine(ornekMetin);
            //Console.WriteLine(ornekMetin.TrimStart());
            //Console.WriteLine(ornekMetin.TrimEnd());
            //Console.WriteLine(ornekMetin.Trim());
            #endregion


            #region String Format
            string no = "123";
            string ad = "Ali";
            string soyad = "Veli";
            Console.WriteLine("------------------");
            Console.WriteLine("Sira No | Adiniz | Soyadiniz");
            Console.WriteLine("--------|--------| ---------");
            Console.WriteLine(String.Format("{0,5} {1,7} {2,7}", no, ad, soyad));


            // Sayila alan 
            Console.WriteLine(String.Format("{0:00000000}", 15));


            //dateTime format
            //Console.WriteLine(String.Format("{0:dd}", DateTime.Now)); // Gun olarak cikar
            //Console.WriteLine(String.Format("{0:ddd}", DateTime.Now)); // Gun ismi  olarak cikar
            //Console.WriteLine(String.Format("{0:dddd}", DateTime.Now)); // Gun ismi  olarak cikar
            //Console.WriteLine(String.Format("{0:hh}", DateTime.Now)); // Saat olarak cikar
            //Console.WriteLine(String.Format("{0:HH}", DateTime.Now)); // Saat olarak cikar
            //Console.WriteLine(String.Format("{0:mm}", DateTime.Now)); // Dakika olarak cikar
            //Console.WriteLine(String.Format("{0:MM}", DateTime.Now)); // Ay olarak cikar
            //Console.WriteLine(String.Format("{0:MMM}", DateTime.Now)); // Ay olarak cikar
            //Console.WriteLine(String.Format("{0:MMMM}", DateTime.Now)); // Ay olarak cikar
            //Console.WriteLine(String.Format("{0:yy}", DateTime.Now)); // yil olarak cikar
            //Console.WriteLine(String.Format("{0:yyyy}", DateTime.Now)); // yil olarak cikar
            //Console.WriteLine(String.Format("{0:hh:mm:ss}", DateTime.Now)); // yil olarak cikar
            //Console.WriteLine(String.Format("{0:dd/MM/yyyy}", DateTime.Now)); // yil olarak cikar
            //Console.WriteLine(String.Format("{0:dd.MM.yyyy}", DateTime.Now)); // yil olarak cikar
            //Console.WriteLine(String.Format("{0:dd-MM-yyyy}", DateTime.Now)); // yil olarak cikar
            //Console.WriteLine(String.Format("{0:dd MM yyyy}", DateTime.Now)); // yil olarak cikar

            #endregion



            key = Console.ReadKey();

            
        }
    }
}
