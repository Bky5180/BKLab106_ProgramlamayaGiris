using YeniiMetrobus.Interface;
using System;

namespace YeniiMetrobus.Concrete
{
    public class ParaUstuCihazi : IParaUstuCihazi, IPandemi
    {
        public int id { get; set; }

        bool corona { get => true; }
        public void paraUstuVer(Yolcu yolcu)
        {
            int a = 0;

            Console.WriteLine("\nYolculuğunuz Sona Erdi. " + yolcu.yolcuInecekDurak + " Durağında İndiniz..\n");

            string paraust = null;
            do
            {
                Console.Write("\nPara Üstü Almak İstiyor Musun?\n1-)Almak İstiyorum  2-)Hayır, Teşekkürler\nMenü Seçim:");
                paraust = Console.ReadLine();

                if (Int32.TryParse(paraust, out a))
                {
                    if (paraust == "1")
                    {
                        int indigidurak = (int)yolcu.yolcuInecekDurak;
                        int bindigidurak = (int)yolcu.yolcuDurakKonum;

                        int gittigiduraksayisi = indigidurak - bindigidurak;
                        int gittigiduraksayisi2 = bindigidurak - indigidurak;

                        if (yolcu.Meslek == karttipi.Ogrenci)
                        {

                            if (gittigiduraksayisi >= 4 && gittigiduraksayisi <= 9 || gittigiduraksayisi2 >= 4 && gittigiduraksayisi2 <= 9)
                            {
                                yolcu.kart.bakiye += 0.10;
                                Console.WriteLine("\nİade Edilen Ücret: 0.10TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi == 3 || gittigiduraksayisi2 == 3)
                            {
                                yolcu.kart.bakiye += 0.30;
                                Console.WriteLine("\nİade Edilen Ücret: 0.30TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi == 2 || gittigiduraksayisi2 == 2)
                            {
                                yolcu.kart.bakiye += 0.50;
                                Console.WriteLine("\nİade Edilen Ücret: 0.50TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi == 1 || gittigiduraksayisi2 == 1)
                            {
                                yolcu.kart.bakiye += 0.60;
                                Console.WriteLine("\nİade Edilen Ücret: 0.60TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else
                            {
                                Console.WriteLine("\nÖğrenci Kartlarında 10 Durak Ve Fazlasına İade Ücret Ödenmiyor..\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }

                        }
                        else if (yolcu.Meslek == karttipi.Normal)
                        {

                            if (gittigiduraksayisi >= 28 && gittigiduraksayisi <= 33 || gittigiduraksayisi2 >= 28 && gittigiduraksayisi2 <= 33)
                            {
                                yolcu.kart.bakiye += 0.35;
                                Console.WriteLine("\nİade Edilen Ücret: 0.35TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi >= 22 && gittigiduraksayisi <= 27 || gittigiduraksayisi2 >= 22 && gittigiduraksayisi2 <= 27)
                            {
                                yolcu.kart.bakiye += 0.45;
                                Console.WriteLine("\nİade Edilen Ücret: 0.45TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi >= 16 && gittigiduraksayisi <= 21 || gittigiduraksayisi2 >= 16 && gittigiduraksayisi2 <= 21)
                            {
                                yolcu.kart.bakiye += 0.60;
                                Console.WriteLine("\nİade Edilen Ücret: 0.60TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi >= 10 && gittigiduraksayisi <= 15 || gittigiduraksayisi2 >= 10 && gittigiduraksayisi2 <= 15)
                            {
                                yolcu.kart.bakiye += 0.80;
                                Console.WriteLine("\nİade Edilen Ücret: 0.80TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi >= 4 && gittigiduraksayisi <= 9 || gittigiduraksayisi2 >= 4 && gittigiduraksayisi2 <= 9)
                            {
                                yolcu.kart.bakiye += 1.20;
                                Console.WriteLine("\nİade Edilen Ücret: 1.20TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi == 3 || gittigiduraksayisi2 == 3)
                            {
                                yolcu.kart.bakiye += 1.70;
                                Console.WriteLine("\nİade Edilen Ücret: 1.70TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi == 2 || gittigiduraksayisi2 == 2)
                            {
                                yolcu.kart.bakiye += 2.20;
                                Console.WriteLine("\nİade Edilen Ücret: 2.20TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi == 1 || gittigiduraksayisi2 == 1)
                            {
                                yolcu.kart.bakiye += 2.70;
                                Console.WriteLine("\nİade Edilen Ücret: 2.70TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else
                            {
                                Console.WriteLine("\nStandart Kartlarda 34 Durak Ve Fazlasına İade Ücret Ödenmiyor..\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }

                        }
                        else if (yolcu.Meslek == karttipi.Ogretmen)
                        {

                            if (gittigiduraksayisi >= 16 && gittigiduraksayisi <= 27 || gittigiduraksayisi2 >= 16 && gittigiduraksayisi2 <= 27)
                            {
                                yolcu.kart.bakiye += 0.15;
                                Console.WriteLine("\nİade Edilen Ücret: 0.15TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi >= 10 && gittigiduraksayisi <= 15 || gittigiduraksayisi2 >= 10 && gittigiduraksayisi2 <= 15)
                            {
                                yolcu.kart.bakiye += 0.30;
                                Console.WriteLine("\nİade Edilen Ücret: 0.30TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi >= 4 && gittigiduraksayisi <= 9 || gittigiduraksayisi2 >= 4 && gittigiduraksayisi2 <= 9)
                            {
                                yolcu.kart.bakiye += 0.35;
                                Console.WriteLine("\nİade Edilen Ücret: 0.35TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi == 3 || gittigiduraksayisi2 == 3)
                            {
                                yolcu.kart.bakiye += 0.70;
                                Console.WriteLine("\nİade Edilen Ücret: 0.70TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi == 2 || gittigiduraksayisi2 == 2)
                            {
                                yolcu.kart.bakiye += 1;
                                Console.WriteLine("\nİade Edilen Ücret: 1TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else if (gittigiduraksayisi == 1 || gittigiduraksayisi2 == 1)
                            {
                                yolcu.kart.bakiye += 1.30;
                                Console.WriteLine("\nİade Edilen Ücret: 1.30TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else
                            {
                                Console.WriteLine("\nÖğretmen Kartlarında 28 Durak Ve Fazlasına İade Ücret Ödenmiyor..\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }

                        }
                        else if (yolcu.Meslek == karttipi.SaglikCalisani)
                        {
                            if (corona)
                            {
                                Console.WriteLine("\nSağlık Çalışanı Kartında İade Alma Hakkınız Yok..\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                            }
                            else
                            {
                                if (gittigiduraksayisi >= 16 && gittigiduraksayisi <= 27 || gittigiduraksayisi2 >= 16 && gittigiduraksayisi2 <= 27)
                                {
                                    yolcu.kart.bakiye += 0.10;
                                    Console.WriteLine("\nİade Edilen Ücret: 0.10TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                                }
                                else if (gittigiduraksayisi >= 10 && gittigiduraksayisi <= 15 || gittigiduraksayisi2 >= 10 && gittigiduraksayisi2 <= 15)
                                {
                                    yolcu.kart.bakiye += 0.20;
                                    Console.WriteLine("\nİade Edilen Ücret: 0.20TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                                }
                                else if (gittigiduraksayisi >= 4 && gittigiduraksayisi <= 9 || gittigiduraksayisi2 >= 4 && gittigiduraksayisi2 <= 9)
                                {
                                    yolcu.kart.bakiye += 0.30;
                                    Console.WriteLine("\nİade Edilen Ücret: 0.30TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                                }
                                else if (gittigiduraksayisi == 3 || gittigiduraksayisi2 == 3)
                                {
                                    yolcu.kart.bakiye += 0.50;
                                    Console.WriteLine("\nİade Edilen Ücret: 0.50TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                                }
                                else if (gittigiduraksayisi == 2 || gittigiduraksayisi2 == 2)
                                {
                                    yolcu.kart.bakiye += 0.80;
                                    Console.WriteLine("\nİade Edilen Ücret: 0.80TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                                }
                                else if (gittigiduraksayisi == 1 || gittigiduraksayisi2 == 1)
                                {
                                    yolcu.kart.bakiye += 1;
                                    Console.WriteLine("\nİade Edilen Ücret: 1TL\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                                }
                                else
                                {
                                    Console.WriteLine("\nSağlık Çalışanı Kartlarında 28 Durak Ve Fazlasına İade Ücret Ödenmiyor..\nKalan Bakiye: " + Math.Round(yolcu.kart.bakiye, 2) + "\n");
                                }
                            }

                        }

                        break;
                    }
                    else if (paraust == "2")
                    {
                        Console.WriteLine();
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
    }
}