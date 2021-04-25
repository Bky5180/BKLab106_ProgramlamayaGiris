using System;

namespace YeniiMetrobus.Concrete
{
    public class Biletmatik
    {
        public int id { get; set; }
        public int bakiyeYukle { get; set; }
        public void paraYukleme(IstanbulKart kart)
        {

            do
            {
                try
                {
                    Console.Write("Kağıt Para Girişi\nYüklemek İstediğiniz Tutarı Giriniz:");
                    bakiyeYukle = Convert.ToInt32(Console.ReadLine());

                    if (bakiyeYukle == 5 || bakiyeYukle == 10 || bakiyeYukle == 5 || bakiyeYukle == 20 || bakiyeYukle == 50 || bakiyeYukle == 100 || bakiyeYukle == 200)
                    {

                        kart.bakiye += bakiyeYukle;

                        Console.WriteLine("\nPara Yüklemeniz Gerçekleşti..\nHesap Bakiyeniz: " + kart.bakiye + "\n");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("\nSadece Kağıt Para Girişi Yapınız..\n");
                    }
                }
                catch
                {
                    Console.WriteLine("\nSadece Kağıt Para Girişi Yapınız..\n");
                }
            } while (true);

        }
    }
}