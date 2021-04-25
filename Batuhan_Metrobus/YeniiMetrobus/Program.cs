using System;
using YeniiMetrobus.Concrete;
using YeniiMetrobus.Interface;

namespace YeniiMetrobus
{
    public delegate void kartOkuma(IstanbulKart kart);
    public delegate void paraYukleme(IstanbulKart kart);
    public delegate void istanbulkartbasvur(Yolcu yolcu);
    public delegate void paraUstu(Yolcu yolcu);
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            bool yetersizbakiye = false;


            MetrobusHatlari Hat = new MetrobusHatlari();
            Yolcu yolcu = new Yolcu();
            BeyazMasa beyazmasa = new BeyazMasa();
            Turnike turnike = new Turnike();
            Biletmatik biletmatik = new Biletmatik();
            ParaUstuCihazi paraustu = new ParaUstuCihazi();
            Guvenlik guvenlik = new Guvenlik();

            yolcu.paraYukle += biletmatik.paraYukleme;
            yolcu.istanbulKartBasvur += beyazmasa.IstanbulKartCikar;
            yolcu.kartOkut += turnike.kartOkut;
            yolcu.paraUstuAl += paraustu.paraUstuVer;



            do
            {

                if (guvenlik.yakalamak >= 2)
                {
                    Console.WriteLine("Hapistesin. 1 Dk. Sabret. Belki Çıkarsın...");
                    System.Threading.Thread.Sleep(60000);
                    Console.WriteLine("Hapis Cezan Bitti. Akıllı Ol Daha Yapma!\n");
                    guvenlik.yakalamak = 0;
                }

                Console.Write("Merhaba. Metrobüs Simülatörüne Hoş Geldiniz..\nNeler Yapmak İstersiniz?\n1-)Profil Oluştur  ||  2-)Profilim  ||  3-)İstanbulKart Başvurusu  ||  4-)İstanbulKarta Para Yükle  ||  5-)Metrobüse Bin  ||  6-)Çıkış\nMenü Seçim:");
                string menu = Console.ReadLine();


                if (Int32.TryParse(menu, out a))
                {
                    if (menu == "1")
                    {
                        if (yolcu.yolcuVarmi)
                        {

                            Console.WriteLine("\nZaten Profiliniz var..\n");

                        }
                        else
                        {
                            do
                            {

                                Console.Write("Ad Soyad:");
                                yolcu.AdSoyad = Console.ReadLine();

                                if (yolcu.AdSoyad == "")
                                {
                                    Console.WriteLine("\nBu Alan Boş Geçilemez..\n");
                                }
                                else
                                {

                                    string sonharf = Convert.ToString(yolcu.AdSoyad[yolcu.AdSoyad.Length - 1]);

                                    if (sonharf == " ")
                                    {

                                        Console.WriteLine("\nLütfen İsim Giriniz");

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            } while (true);
                            do
                            {
                                Console.Write("Meslek: Sağlık Çalışanıysanız 1, Öğretmenseniz 2, Öğrenciyseniz 3'e Tıklayın.\nSeçeneklerden biri değilse mesleğinizi yazınız:");
                                string meslek = Console.ReadLine();

                                if (meslek == "1")
                                {
                                    yolcu.Meslek = karttipi.SaglikCalisani;
                                    yolcu.yolcuVarmi = true;
                                    Console.WriteLine("\nProfil Oluşturuldu..\n");
                                    break;
                                }
                                else if (meslek == "2")
                                {
                                    yolcu.Meslek = karttipi.Ogretmen;
                                    yolcu.yolcuVarmi = true;
                                    Console.WriteLine("\nProfil Oluşturuldu..\n");
                                    break;
                                }
                                else if (meslek == "3")
                                {
                                    yolcu.Meslek = karttipi.Ogrenci;
                                    yolcu.yolcuVarmi = true;
                                    Console.WriteLine("\nProfil Oluşturuldu..\n");
                                    break;
                                }
                                else
                                {
                                    if (meslek == "")
                                    {
                                        Console.WriteLine("\nBu Alan Boş Geçilemez..\n");
                                    }
                                    else
                                    {
                                        yolcu.Meslek = karttipi.Normal;
                                        yolcu.yolcuVarmi = true;
                                        Console.WriteLine("\nProfil Oluşturuldu..\n");
                                        break;
                                    }
                                }
                            } while (true);
                        }
                    }
                    else if (menu == "2")
                    {
                        do
                        {
                            if (!yolcu.yolcuVarmi)
                            {
                                Console.WriteLine("\nProfil Oluşturmadan Profil Görüntüleyemezsiniz..\n");
                                break;
                            }
                            else
                            {

                                Console.WriteLine("\nAdınız ve Soyadınız:" + yolcu.AdSoyad);
                                Console.WriteLine("İstanbul Kart: " + (yolcu.istanbulkartvarmi ? "Var" : "Yok"));
                                if (yolcu.istanbulkartvarmi)
                                {
                                    Console.WriteLine("İstanbul Kart No: " + yolcu.kart.kartNo);
                                    Console.WriteLine("İstanbul Kart Tipi: " + yolcu.kart.kartTipi);
                                    Console.WriteLine("İstanbul Kart Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "TL");
                                }
                                Console.Write("1-)Ana Menü  || 2-)Çıkış\nMenü Seçim:");
                                string profilMenu = Console.ReadLine();
                                if (Int32.TryParse(profilMenu, out a))
                                {
                                    if (profilMenu == "1")
                                    {
                                        Console.WriteLine();
                                        break;
                                    }
                                    else if (profilMenu == "2")
                                    {
                                        Console.WriteLine("\nHoşçakalın...");
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nLütfen Menüde ki Seçeneklerden Birini Seçiniz..\n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nLütfen Sayı Giriniz..\n");
                                }
                            }
                        } while (true);
                    }
                    else if (menu == "3")
                    {
                        do
                        {
                            if (!yolcu.yolcuVarmi)
                            {

                                Console.WriteLine("\nProfil Oluşturmadan Kart Başvurusu Yapamazsınız..\n");
                                break;

                            }
                            else
                            {
                                if (yolcu.istanbulkartvarmi)
                                {
                                    Console.WriteLine("\nEn Fazla 1 İstanbul Kart Sahibi Olabilirsiniz..\n");
                                    break;
                                }
                                else
                                {

                                    yolcu.istanbulKartBasvurusu();

                                    Console.WriteLine("\nİstanbul Kartınız Çıktı. Hayırlı Olsun..\n");
                                    break;
                                }
                            }

                        } while (true);
                    }
                    else if (menu == "4")
                    {
                        do
                        {
                            try
                            {
                                Console.Write("\nİstanbul Kart No Giriniz:");
                                int istanbulKartNo = Convert.ToInt32(Console.ReadLine());

                                if (!yolcu.istanbulkartvarmi)
                                {

                                    Console.WriteLine("\nKart Kayıtlı Değil. Yanlışlık Olduğunu Düşünüyorsanız Alo 153 ile İrtibata Geçiniz..\n");
                                    break;
                                }
                                else
                                {
                                    if (yolcu.kart.kartNo == istanbulKartNo)
                                    {

                                        yolcu.biletmatikKullan();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nKart Kayıtlı Değil. Yanlışlık Olduğunu Düşünüyorsanız Alo 153 ile İrtibata Geçiniz..\n");
                                        break;
                                    }

                                }
                            }
                            catch
                            {
                                Console.WriteLine("\nLütfen Sayı Giriniz..");
                            }
                        } while (true);
                    }
                    else if (menu == "5")
                    {
                        do
                        {
                            string bin = null;

                            if (!yolcu.istanbulkartvarmi)
                            {
                                do
                                {

                                    Console.Write("\nİstanbul Kartın Yok. Gizlice binmek ister misin?\n1-)Evet   2-)Hayır\nMenü Seçim:");
                                    bin = Console.ReadLine();

                                    if (Int32.TryParse(bin, out a))
                                    {
                                        if (bin == "1")
                                        {
                                            Random s = new Random();
                                            int kacak = s.Next(2);

                                            if (kacak == 0)
                                            {
                                                yolcu.kacakyolcu = false;
                                                Console.WriteLine("\nGüvenliğe Yakalandın. Şanslısın. Bu Seferlik Seni Bıraktı. Bir Daha Yapma!!\n");
                                                guvenlik.yakalamak += 1;

                                                if (guvenlik.yakalamak >= 2)
                                                {
                                                    Console.WriteLine("\nYeter Artık Be Bu Kaç Oldu. Hapsin Yolunu Tut Bakalım..\n");
                                                    break;
                                                }
                                                break;
                                            }
                                            else if (kacak == 1)
                                            {
                                                yolcu.kacakyolcu = true;
                                                bin = "3";
                                                Console.WriteLine("\nŞanslısın. Güvenliğe Yakalanmadan Geçmeyi Başardın..\n");
                                                break;
                                            }

                                        }
                                        else if (bin == "2")
                                        {
                                            yolcu.kacakyolcu = false;
                                            Console.WriteLine("\nÖrnek Vatandaş..\n");
                                            break;
                                        }
                                        else
                                        {

                                            Console.WriteLine("\nLütfen Menüde ki Seçeneklerden Birini Seçiniz..\n");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n Lütfen Sayı Giriniz..\n");
                                    }
                                } while (true);
                            }

                            if (bin == "1" || bin == "2")
                            {
                                bin = null;
                                break;
                            }

                            do
                            {
                                do
                                {
                                    try
                                    {
                                        if (yolcu.istanbulkartvarmi)
                                        {
                                            yolcu.kacakyolcu = false;

                                            if (yolcu.kart.kartTipi == karttipi.Ogrenci && yolcu.kart.bakiye < 1.70)
                                            {
                                                Console.WriteLine("\nYetersiz Bakiye. Lütfen Para Yüklemesi Yapınız\nBakiye: " + yolcu.kart.bakiye + "\n");
                                                yetersizbakiye = true;
                                                break;
                                            }
                                            else if (yolcu.kart.kartTipi == karttipi.Normal && yolcu.kart.bakiye < 5.20)
                                            {
                                                Console.WriteLine("\nYetersiz Bakiye. Lütfen Para Yüklemesi Yapınız\nBakiye: " + yolcu.kart.bakiye + "\n");
                                                yetersizbakiye = true;
                                                break;
                                            }
                                            else if (yolcu.kart.kartTipi == karttipi.Ogretmen && yolcu.kart.bakiye < 2.85)
                                            {
                                                Console.WriteLine("\nYetersiz Bakiye. Lütfen Para Yüklemesi Yapınız\nBakiye: " + yolcu.kart.bakiye + "\n");
                                                yetersizbakiye = true;
                                                break;
                                            }
                                            else if (yolcu.kart.kartTipi == karttipi.SaglikCalisani && yolcu.kart.bakiye < 2.50 && !turnike.corona)
                                            {
                                                Console.WriteLine("\nYetersiz Bakiye. Lütfen Para Yüklemesi Yapınız\nBakiye: " + yolcu.kart.bakiye + "\n");
                                                yetersizbakiye = true;
                                                break;
                                            }
                                        }

                                        yolcu.hatdenetle = null;

                                        Console.WriteLine("\n  No           Hat Adı");
                                        foreach (var value in Enum.GetValues(typeof(yolcuhatkonum)))
                                        {
                                            Console.WriteLine("{0,3}:     {1}", (int)value, ((yolcuhatkonum)value));
                                        }


                                        Console.Write("\nLütfen Yukarıdan Bir Hat Seçiniz:");
                                        int hatSecim = Convert.ToInt32(Console.ReadLine());

                                        if (hatSecim < 9)
                                        {
                                            yolcu.yolcuHatKonum = (yolcuhatkonum)hatSecim;
                                            Console.WriteLine("\n");


                                            break;



                                        }
                                        else
                                        {
                                            Console.WriteLine("\nLütfen Menüde ki Hatlardan Birini Seçiniz..\n");
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("\nLütfen Sayı Giriniz..\n");
                                    }
                                } while (true);
                                if (yetersizbakiye)
                                {
                                    break;
                                }

                                do
                                {
                                    try
                                    {
                                        yolcu.denetle = null;


                                        Console.WriteLine("  No     Durak Adı");
                                        foreach (var value in Enum.GetValues(typeof(yolcudurakkonum)))
                                        {
                                            Console.WriteLine("{0,3}:     {1}", (int)value, ((yolcudurakkonum)value));
                                        }

                                        Console.Write("\nLütfen Metrobüse Binmek İstediğiniz Durağı Seçiniz:");
                                        int durakSecim = Convert.ToInt32(Console.ReadLine());

                                        if (durakSecim < 45)
                                        {

                                            yolcu.yolcuDurakKonum = (yolcudurakkonum)durakSecim;
                                            Console.WriteLine("\n");





                                            yolcu.MetrobuseBin(Hat);


                                            if (yolcu.denetle != "y")
                                            {

                                                break;
                                            }
                                            else if (yolcu.hatdenetle == "besleme")
                                            {

                                                break;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("\nLütfen Menüde ki Duraklardan Birini Seçiniz..\n");
                                        }


                                    }
                                    catch
                                    {
                                        Console.WriteLine("\nLütfen Sayı Giriniz..\n");
                                    }
                                } while (true);

                                if (yolcu.denetle != "y" && yolcu.hatdenetle != "besleme")
                                {

                                    yolcu.denetle = null;
                                    yolcu.hatdenetle = null;
                                    break;
                                }

                            } while (true);
                            if (yetersizbakiye)
                            {
                                yetersizbakiye = false;
                                break;
                            }

                            Console.WriteLine("Metrobüse bindiniz...");



                            do
                            {
                                try
                                {

                                    yolcu.denetle = null;

                                    Console.WriteLine("\n");

                                    Console.WriteLine("  No     Durak Adı");
                                    foreach (var value in Enum.GetValues(typeof(yolcudurakkonum)))
                                    {
                                        Console.WriteLine("{0,3}:     {1}", (int)value, ((yolcudurakkonum)value));
                                    }

                                    Console.Write("\nLütfen İnmek İstediğiniz Durağı Seçiniz:");
                                    int inecekdurakSecim = Convert.ToInt32(Console.ReadLine());

                                    if (inecekdurakSecim < 45)
                                    {
                                        yolcu.yolcuInecekDurak = (yolcudurakkonum)inecekdurakSecim;
                                        Console.WriteLine("\n");

                                        yolcu.MetrobusdenIn(Hat);

                                        if (yolcu.denetle != "y")
                                        {
                                            yolcu.denetle = null;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nLütfen Menüde ki Duraklardan Birini Seçiniz..\n");
                                    }


                                }
                                catch
                                {
                                    Console.WriteLine("\nLütfen Sayı Giriniz..\n");
                                }

                            } while (true);
                         
                            if (yolcu.denetle != "y")
                            {
                                yolcu.denetle = null;
                                break;
                            }
                            
                        } while (true);
                    }
                    else if (menu == "6")
                    {
                        Console.WriteLine("\nHoşçakalın...");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("\nLütfen Menüde ki Seçeneklerden Birini Seçiniz..\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nLütfen Sayı Giriniz..\n");
                }
            } while (true);
        }
    }

}
