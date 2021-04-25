using YeniiMetrobus.Interface;
using System;

namespace YeniiMetrobus.Concrete
{

    public class Yolcu : IYolcu
    {
        public bool kacakyolcu { get; set; }
        public string denetle { get; set; }
        public string hatdenetle { get; set; }
        bool _yolcuvarmi;
        public bool yolcuVarmi
        {
            get
            {
                return _yolcuvarmi;
            }
            set
            {
                _yolcuvarmi = value;
            }
        }
        public bool istanbulkartvarmi { get; set; }
        public string AdSoyad { get; set; }
        public karttipi Meslek { get; set; }
        public event istanbulkartbasvur istanbulKartBasvur;
        public event paraYukleme paraYukle;
        public event kartOkuma kartOkut;
        public event paraUstu paraUstuAl;
        public yolcuhatkonum yolcuHatKonum { get; set; }
        public yolcudurakkonum yolcuDurakKonum { get; set; }
        public yolcudurakkonum yolcuInecekDurak { get; set; }
        public IstanbulKart kart { get; set; }
        int yolcudurakkonum;
        public void istanbulKartBasvurusu()
        {
            istanbulKartBasvur(this);
        }
        public void MetrobuseBin(MetrobusHatlari hat)
        {
            int yolcuhatkonum = (int)yolcuHatKonum;
            yolcudurakkonum = (int)yolcuDurakKonum;



            if (DateTime.Now.Hour <= 05.00 && DateTime.Now.Hour >= 03.00)
            {
                Console.WriteLine("03-00 / 05-00 Arası Otobüs Yok");
                denetle = "y";

            }
            else if (yolcuhatkonum == 1 || yolcuhatkonum == 2 || yolcuhatkonum == 3 || yolcuhatkonum == 4)
            {

                hat.Hatlar = hatlar.AnaHat;

                int avcilarsogutlucesme = (int)hatadi.AvcilarSogutlucesme;
                int avcilarzincilikuyu = (int)hatadi.AvcilarZincirlikuyu;
                int beylikduzucevizlibag = (int)hatadi.BeylikduzuCevizlibag;
                int beylikduzuzincirlikuyu = (int)hatadi.BeylikduzuZincirlikuyu;

                if (yolcuhatkonum == avcilarsogutlucesme)
                {


                    if (yolcudurakkonum < 12)
                    {
                        Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                        denetle = "y";
                    }
                    else
                    {
                        if (kacakyolcu)
                        {

                        }
                        else
                        {
                            kartOkut(kart);
                        }
                    }
                }
                else if (yolcuhatkonum == avcilarzincilikuyu)
                {
                    if (yolcudurakkonum < 12 || yolcudurakkonum > 37)
                    {
                        Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                        denetle = "y";
                    }
                    else
                    {
                        if (kacakyolcu)
                        {

                        }
                        else
                        {
                            kartOkut(kart);
                        }
                    }
                }
                else if (yolcuhatkonum == beylikduzucevizlibag)
                {

                    if (yolcudurakkonum > 26)
                    {
                        Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                        denetle = "y";
                    }
                    else
                    {
                        if (kacakyolcu)
                        {

                        }
                        else
                        {
                            kartOkut(kart);
                        }
                    }

                }
                else if (yolcuhatkonum == beylikduzuzincirlikuyu)
                {

                    if (yolcudurakkonum > 37)
                    {
                        Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                        denetle = "y";
                    }
                    else
                    {
                        if (kacakyolcu)
                        {

                        }
                        else
                        {
                            kartOkut(kart);
                        }
                    }

                }
            }
            else if (yolcuhatkonum == 5 || yolcuhatkonum == 6 || yolcuhatkonum == 7 || yolcuhatkonum == 8)
            {
                if (DateTime.Now.Hour >= 18 - 00 && DateTime.Now.Hour <= 23 - 00)
                {

                    hat.Hatlar = hatlar.BeslemeHat;

                    int sogutlucesmeedirnekapi = (int)hatadi.SogutlucesmeEdirnekapi;
                    int beylikduzuavcilar = (int)hatadi.BeylikduzuAvcilar;
                    int avcilartopkapi = (int)hatadi.AvcılarŞehitmustafacambaz;
                    int uzuncayırzincirlikuyu = (int)hatadi.UzunçayırZincirlikuyu;

                    if (yolcuhatkonum == sogutlucesmeedirnekapi)
                    {


                        if (yolcudurakkonum < 29)
                        {
                            Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                            denetle = "y";
                        }
                        else
                        {
                            if (kacakyolcu)
                            {

                            }
                            else
                            {
                                kartOkut(kart);
                            }
                        }
                    }
                    else if (yolcuhatkonum == beylikduzuavcilar)
                    {
                        if (yolcudurakkonum > 12)
                        {
                            Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                            denetle = "y";
                        }
                        else
                        {
                            if (kacakyolcu)
                            {

                            }
                            else
                            {
                                kartOkut(kart);
                            }
                        }
                    }
                    else if (yolcuhatkonum == avcilartopkapi)
                    {

                        if (yolcudurakkonum > 27 || yolcudurakkonum < 12)
                        {
                            Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                            denetle = "y";
                        }
                        else
                        {
                            if (kacakyolcu)
                            {

                            }
                            else
                            {
                                kartOkut(kart);
                            }
                        }

                    }
                    else if (yolcuhatkonum == uzuncayırzincirlikuyu)
                    {

                        if (yolcudurakkonum > 42 || yolcudurakkonum < 37)
                        {
                            Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                            denetle = "y";
                        }
                        else
                        {
                            if (kacakyolcu)
                            {

                            }
                            else
                            {
                                kartOkut(kart);
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Besleme Hat 18:00 - 23:00 arası çalışıyor. Lütfen ana hat güzargahında bekleyiniz..\n");
                    hatdenetle = "besleme";
                }
            }

        }

        public void MetrobusdenIn(MetrobusHatlari hat)
        {
            int yolcuhatkonum = (int)yolcuHatKonum;
            int yolcuinecekdurakkonum = (int)yolcuInecekDurak;


            hat.Hatlar = hatlar.AnaHat;

            int avcilarsogutlucesme = (int)hatadi.AvcilarSogutlucesme;
            int avcilarzincilikuyu = (int)hatadi.AvcilarZincirlikuyu;
            int beylikduzucevizlibag = (int)hatadi.BeylikduzuCevizlibag;
            int beylikduzuzincirlikuyu = (int)hatadi.BeylikduzuZincirlikuyu;

            if (yolcuhatkonum == avcilarsogutlucesme)
            {


                if (yolcuinecekdurakkonum < 12)
                {
                    Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                    denetle = "y";
                }
                else if (yolcudurakkonum == yolcuinecekdurakkonum)
                {

                    Console.WriteLine("Otobüs Hareket Etti. Bindiğin Durakta İnemezsin..\n");
                    denetle = "y";
                }
                else
                {
                    if (kacakyolcu)
                    {
                        Console.WriteLine("\nYolculuğunuz Sona Erdi. Güvenliğe Yakalanmadan " + yolcuInecekDurak + " Durağında İndiniz..\n");
                    }
                    else
                    {
                        paraUstuAl(this);
                    }

                }
            }
            else if (yolcuhatkonum == avcilarzincilikuyu)
            {
                if (yolcuinecekdurakkonum < 12 || yolcuinecekdurakkonum > 37)
                {
                    Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                    denetle = "y";
                }
                else if (yolcudurakkonum == yolcuinecekdurakkonum)
                {

                    Console.WriteLine("Otobüs Hareket Etti. Bindiğin Durakta İnemezsin..\n");
                    denetle = "y";
                }
                else
                {
                    if (kacakyolcu)
                    {
                        Console.WriteLine("\nYolculuğunuz Sona Erdi. Güvenliğe Yakalanmadan " + yolcuInecekDurak + " Durağında İndiniz..\n");
                    }
                    else
                    {
                        paraUstuAl(this);
                    }
                }
            }
            else if (yolcuhatkonum == beylikduzucevizlibag)
            {

                if (yolcuinecekdurakkonum > 26)
                {
                    Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                    denetle = "y";
                }
                else if (yolcudurakkonum == yolcuinecekdurakkonum)
                {

                    Console.WriteLine("Otobüs Hareket Etti. Bindiğin Durakta İnemezsin..\n");
                    denetle = "y";
                }
                else
                {
                    if (kacakyolcu)
                    {
                        Console.WriteLine("\nYolculuğunuz Sona Erdi. Güvenliğe Yakalanmadan " + yolcuInecekDurak + " Durağında İndiniz..\n");
                    }
                    else
                    {
                        paraUstuAl(this);
                    }
                }

            }
            else if (yolcuhatkonum == beylikduzuzincirlikuyu)
            {

                if (yolcuinecekdurakkonum > 37)
                {
                    Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                    denetle = "y";
                }
                else if (yolcudurakkonum == yolcuinecekdurakkonum)
                {

                    Console.WriteLine("Otobüs Hareket Etti. Bindiğin Durakta İnemezsin..\n");
                    denetle = "y";
                }
                else
                {
                    if (kacakyolcu)
                    {
                        Console.WriteLine("\nYolculuğunuz Sona Erdi. Güvenliğe Yakalanmadan " + yolcuInecekDurak + " Durağında İndiniz..\n");
                    }
                    else
                    {
                        paraUstuAl(this);
                    }
                }

            }

            else if (DateTime.Now.Hour >= 18 - 00 && DateTime.Now.Hour <= 23 - 00)
            {

                hat.Hatlar = hatlar.BeslemeHat;

                int sogutlucesmeedirnekapi = (int)hatadi.SogutlucesmeEdirnekapi;
                int beylikduzuavcilar = (int)hatadi.BeylikduzuAvcilar;
                int avcilartopkapi = (int)hatadi.AvcılarŞehitmustafacambaz;
                int uzuncayırzincirlikuyu = (int)hatadi.UzunçayırZincirlikuyu;

                if (yolcuhatkonum == sogutlucesmeedirnekapi)
                {


                    if (yolcuinecekdurakkonum < 29)
                    {
                        Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                        denetle = "y";
                    }
                    else if (yolcudurakkonum == yolcuinecekdurakkonum)
                    {

                        Console.WriteLine("Otobüs Hareket Etti. Bindiğin Durakta İnemezsin..\n");
                        denetle = "y";
                    }
                    else
                    {
                        if (kacakyolcu)
                        {
                            Console.WriteLine("\nYolculuğunuz Sona Erdi. Güvenliğe Yakalanmadan " + yolcuInecekDurak + " Durağında İndiniz..\n");
                        }
                        else
                        {
                            paraUstuAl(this);
                        }
                    }
                }
                else if (yolcuhatkonum == beylikduzuavcilar)
                {
                    if (yolcuinecekdurakkonum > 12)
                    {
                        Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                        denetle = "y";
                    }
                    else if (yolcudurakkonum == yolcuinecekdurakkonum)
                    {

                        Console.WriteLine("Otobüs Hareket Etti. Bindiğin Durakta İnemezsin..\n");
                        denetle = "y";
                    }
                    else
                    {
                        if (kacakyolcu)
                        {
                            Console.WriteLine("\nYolculuğunuz Sona Erdi. Güvenliğe Yakalanmadan " + yolcuInecekDurak + " Durağında İndiniz..\n");
                        }
                        else
                        {
                            paraUstuAl(this);
                        }
                    }
                }
                else if (yolcuhatkonum == avcilartopkapi)
                {

                    if (yolcuinecekdurakkonum > 27 || yolcuinecekdurakkonum < 12)
                    {
                        Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                        denetle = "y";
                    }
                    else if (yolcudurakkonum == yolcuinecekdurakkonum)
                    {

                        Console.WriteLine("Otobüs Hareket Etti. Bindiğin Durakta İnemezsin..\n");
                        denetle = "y";
                    }
                    else
                    {
                        if (kacakyolcu)
                        {
                            Console.WriteLine("\nYolculuğunuz Sona Erdi. Güvenliğe Yakalanmadan " + yolcuInecekDurak + " Durağında İndiniz..\n");
                        }
                        else
                        {
                            paraUstuAl(this);
                        }
                    }

                }
                else if (yolcuhatkonum == uzuncayırzincirlikuyu)
                {

                    if (yolcuinecekdurakkonum > 42 || yolcuinecekdurakkonum < 37)
                    {
                        Console.WriteLine("Lütfen Hat İçerisinden Durak Seçiniz\n");
                        denetle = "y";
                    }
                    else if (yolcudurakkonum == yolcuinecekdurakkonum)
                    {

                        Console.WriteLine("Otobüs Hareket Etti. Bindiğin Durakta İnemezsin..\n");
                        denetle = "y";
                    }
                    else
                    {
                        if (kacakyolcu)
                        {
                            Console.WriteLine("\nYolculuğunuz Sona Erdi. Güvenliğe Yakalanmadan " + yolcuInecekDurak + " Durağında İndiniz..\n");
                        }
                        else
                        {
                            paraUstuAl(this);
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("Besleme Hat 18:00 - 23:00 arası çalışıyor. Lütfen ana hat güzargahında bekleyiniz..\n");
                denetle = "y";
            }
        }
        public void biletmatikKullan()
        {
            paraYukle(kart);
        }
    }
}