using System;
using YeniiMetrobus.Interface;

namespace YeniiMetrobus.Concrete
{
    public class Turnike : IPandemi
    {
        public int turnikeId { get; set; }
        double _ogrenciTarifesi = 1.70;
        double _normalTarife = 5.20;
        double _ogretmenTarifesi = 2.85;
        double _saglikCalisaniTarifesi = 2.50;
        public bool corona { get => true; }
        public void kartOkut(IstanbulKart kart)
        {
            switch (kart.kartTipi)
            {
                case karttipi.Ogrenci:
                    if (kart.bakiye < _ogrenciTarifesi)
                    {
                        Console.WriteLine("Bakiye Yetersiz:" + Math.Round(kart.bakiye, 2));
                    }
                    else
                    {
                        kart.bakiye -= _ogrenciTarifesi;
                        Console.WriteLine("Kalan Bakiye:" + Math.Round(kart.bakiye, 2));
                    }
                    break;
                case karttipi.Normal:
                    if (kart.bakiye < _normalTarife)
                    {
                        Console.WriteLine("Bakiye Yetersiz:" + Math.Round(kart.bakiye, 2));
                    }
                    else
                    {
                        kart.bakiye -= _normalTarife;
                        Console.WriteLine("Kalan Bakiye:" + Math.Round(kart.bakiye, 2));
                    }

                    break;
                case karttipi.Ogretmen:
                    if (kart.bakiye < _ogretmenTarifesi)
                    {
                        Console.WriteLine("Bakiye Yetersiz:" + Math.Round(kart.bakiye, 2));
                    }
                    else
                    {
                        kart.bakiye -= _ogretmenTarifesi;
                        Console.WriteLine("Kalan Bakiye:" + Math.Round(kart.bakiye, 2));
                    }
                    break;
                case karttipi.SaglikCalisani:
                    if (!corona)
                    {
                        if (kart.bakiye < _saglikCalisaniTarifesi)
                        {
                            Console.WriteLine("Bakiye Yetersiz:" + Math.Round(kart.bakiye, 2));
                        }
                        else
                        {
                            kart.bakiye -= _saglikCalisaniTarifesi;
                            Console.WriteLine("Kalan Bakiye:" + Math.Round(kart.bakiye, 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ücretsiz Geçiş");
                    }
                    break;
                default:

                    break;
            }
        }
    }
}