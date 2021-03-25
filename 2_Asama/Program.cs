using System;

namespace _2_Asama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programda bize öğretilen Method ve Try/Catch kullanmadım.
             
            string ad = null;
            string sifre = null;
            string anne = null;
            DateTime tarih = default(DateTime);
        a:
            Console.WriteLine("1-)Giriş\n2-)Kayıt Ol\n3-)Şifremi Unuttum\n4-)Çıkış");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
            b:
                string ad1 = null;
                string sifre1 = null;
                Console.Write("Kullanıcı Adı:");
                ad1 = Console.ReadLine();
                Console.Write("Şifre:");
                sifre1 = Console.ReadLine();

                if (ad1 == ad && sifre1 == sifre)
                {
                    Console.WriteLine($"Hoşgeldin {ad}");
                    Console.WriteLine($"Giriş Yaptığın Zaman:{DateTime.Now}");

                }
                else if (ad == null && sifre == null)
                {
                    Console.WriteLine("Lütfen Kayıt Olunuz..");
                    goto a;
                }
                else if (ad1 != ad && sifre1 == sifre)
                {
                    Console.WriteLine("Kullanıcı Adını Yanlış Girdiniz..");
                    Console.Write("1-)Denemeye Devam Et\n2-)Çıkış:");
                    int b = Convert.ToInt32(Console.ReadLine());

                    if (b == 1)
                    {
                        goto b;
                    }
                    else if (b == 2)
                    {
                        Console.WriteLine("Hoşçakal..");
                        Environment.Exit(0);
                    }
                }
                else if (ad1 == ad && sifre1 != sifre)
                {
                    Console.WriteLine("Şifreyi Yanlış Girdiniz..");
                    Console.Write("1-)Denemeye Devam Et\n2-)Çıkış:");
                    int b = Convert.ToInt32(Console.ReadLine());

                    if (b == 1)
                    {
                        goto b;
                    }
                    else if (b == 2)
                    {
                        Console.WriteLine("Hoşçakal..");
                        Environment.Exit(0);
                    }
                }
                else if (ad1 != ad && sifre1 != sifre)
                {
                    Console.WriteLine("Kullanıcı Adı ve Şifreyi Yanlış Girdiniz..");
                    Console.Write("1-)Denemeye Devam Et\n2-)Çıkış:");
                    int b = Convert.ToInt32(Console.ReadLine());

                    if (b == 1)
                    {
                        goto b;
                    }
                    else if (b == 2)
                    {
                        Console.WriteLine("Hoşçakal..");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Giriş Başarısız...");
                }

            }
            else if (a == 2)
            {
                Console.Write("Kullanıcı Adı:");
                ad = Console.ReadLine();
                Console.Write("Şifre:");
                sifre = Console.ReadLine();
                Console.Write("Annenizin Adı:");
                anne = Console.ReadLine();
                Console.Write("Doğum Tarihiniz:");
                tarih = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Kayıt Başarılı..");
                goto a;
            }
            else if (a == 3)
            {
            c:
                Console.Write("Kullanıcı Adınız:");
                string ad2 = Console.ReadLine();

                if (ad2 != ad)
                {
                    Console.WriteLine($"\"{ad2}\" 'lı kullanıcı kayıtlı değil..");
                    Console.WriteLine("1-)Denemeye Devam Et\n2-)Ana Menü\n3-)Çıkış");
                    int b = Convert.ToInt32(Console.ReadLine());

                    if (b == 1)
                    {
                        goto c;
                    }
                    else if (b == 2)
                    {
                        goto a;
                    }
                    else if (b == 3)
                    {
                        Console.WriteLine("Hoşçakal..");
                        Environment.Exit(0);
                    }
                }
                else if (ad2 == ad)
                {
                m:
                    Console.Write("Doğum Tarihinizi Giriniz:");
                    DateTime tarih1 = Convert.ToDateTime(Console.ReadLine());

                    if (tarih != tarih1)
                    {
                        Console.WriteLine("Hatalı Giriş Yaptınız...\n1-)Tekrar Dene\n2-)Ana Menü\n3-)Çıkış");
                        int k = Convert.ToInt32(Console.ReadLine());

                        if (k == 1)
                        {
                            goto m;
                        }
                        else if (k == 2)
                        {
                            goto a;
                        }
                        else if (k == 3)
                        {
                            Console.WriteLine("Hoşçakal...");
                            Environment.Exit(0);
                        }
                    }
                    else if (tarih == tarih1)
                    {
                    y:
                        Console.WriteLine("Annenizin Adı Kaç Harften Oluşuyor?");
                        int anne2 = Convert.ToInt32(Console.ReadLine());

                        int harf = anne.Length;

                        if (harf == anne2)
                        {
                            Console.Write("Yeni Şifre:");
                            sifre = Console.ReadLine();

                            Console.WriteLine("Sen Robot musun?\nAşağıdaki sayının aynısını giriniz...");
                            Random rastgele = new Random();
                            int sayi = rastgele.Next(999999);
                            Console.Write($"{sayi}:");
                            int veri = Convert.ToInt32(Console.ReadLine());

                            if (veri == sayi)
                            {
                                Console.WriteLine("Şifreniz Değiştirildi..");
                                goto a;
                            }
                            else if (veri != sayi)
                            {
                                Console.WriteLine("Robot olma ihtimalinizden dolayı çıkış yapılıyor..");
                                Environment.Exit(0);
                            }
                        }
                        else if (harf != anne2)
                        {
                            Console.WriteLine("Hatalı Giriş..\n1-)Tekrar Dene\n2-)Ana Menü\n3-)Çıkış");
                            int t = Convert.ToInt32(Console.ReadLine());

                            if (t == 1)
                            {
                                goto y;
                            }
                            else if (t == 2)
                            {
                                goto a;
                            }
                            else if (t == 3)
                            {
                                Console.WriteLine("Hoşçakal...");
                                Environment.Exit(0);
                            }
                        }
                    }


                }
            }
            else if (a == 4)
            {
                Console.WriteLine("Hoşçakal..");
                Environment.Exit(0);
            }
        }
    }
}