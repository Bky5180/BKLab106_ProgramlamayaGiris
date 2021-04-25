using YeniiMetrobus.Interface;
using System;

namespace YeniiMetrobus.Concrete
{
    public class BeyazMasa
    {

        public int id { get; set; }
        public string subeAdi { get; set; }

        public void IstanbulKartCikar(Yolcu yolcu)
        {

            Random sayi = new Random();
            int rastgele = sayi.Next(999);

            if (yolcu.Meslek == karttipi.Ogrenci)
            {
                yolcu.kart = new IstanbulKart()
                {

                    yolcuAd = yolcu.AdSoyad,
                    kartNo = rastgele,
                    bakiye = 0,
                    kartTipi = karttipi.Ogrenci,

                };
                yolcu.istanbulkartvarmi = true;
            }
            else if (yolcu.Meslek == karttipi.Normal)
            {
                yolcu.kart = new IstanbulKart()
                {

                    yolcuAd = yolcu.AdSoyad,
                    kartNo = rastgele,
                    bakiye = 0,
                    kartTipi = karttipi.Normal,
                };
                yolcu.istanbulkartvarmi = true;
            }
            else if (yolcu.Meslek == karttipi.Ogretmen)
            {
                yolcu.kart = new IstanbulKart()
                {

                    yolcuAd = yolcu.AdSoyad,
                    kartNo = rastgele,
                    bakiye = 0,
                    kartTipi = karttipi.Ogretmen,
                };
                yolcu.istanbulkartvarmi = true;
            }
            else if (yolcu.Meslek == karttipi.SaglikCalisani)
            {
                yolcu.kart = new IstanbulKart()
                {

                    yolcuAd = yolcu.AdSoyad,
                    kartNo = rastgele,
                    bakiye = 0,
                    kartTipi = karttipi.SaglikCalisani,
                };
                yolcu.istanbulkartvarmi = true;
            }

        }
    }
}