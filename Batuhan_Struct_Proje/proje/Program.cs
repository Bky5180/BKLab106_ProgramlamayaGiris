using System;

namespace proje
{
    class Program
    {
        static void Main(string[] args)
        {
            Veri bilgi = new Veri();
            do
            {
                Console.Write("1-)Personel Kayıt\n2-)Personel Bilgileri\n3-)Çıkış\nSayı:");
                bilgi.deger = Console.ReadLine();

                if (bilgi.deger == "1")
                {

                    Console.Write("Ad:");
                    bilgi.ad = Console.ReadLine();

                    do
                    {
                        Console.Write("Tc:");
                        bilgi.mesaj = bilgi.tcKontrol(Console.ReadLine());

                        if (bilgi.mesaj == "Lütfen Sayı Giriniz")
                        {
                            Console.WriteLine(bilgi.mesaj);
                        }
                        else
                        {
                            if (bilgi.mesaj == "Doğru")
                            {



                                if (bilgi.mesaj != "Kayıt Var")
                                {   
                                    int boyut = 1;
                                    Array.Resize(ref bilgi.personel,boyut);

                                    for(var i = 0; i < bilgi.personel.Length; i++ ){
                                        bilgi.personel[i] +="Ad: "+bilgi.ad+" "+"TC:"+bilgi.tcGonder()+"\n";
                                    }
                                    boyut++;
                                    Console.WriteLine("\nKayıt Başarılı..\n");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(bilgi.mesaj);
                                }

                            }
                            else
                            {
                                Console.WriteLine(bilgi.mesaj);
                            }
                        }
                    } while (true);

                }
                else if (bilgi.deger == "2")
                {
                    foreach (var item in bilgi.personel)
                    {
                        Console.WriteLine(item);
                    }
                }
            } while (bilgi.deger != "3");


        }
    }
}
