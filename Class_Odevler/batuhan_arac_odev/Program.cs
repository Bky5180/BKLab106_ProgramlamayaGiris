using System;
using batuhan_arac_odev.Araclar;

namespace batuhan_arac_odev
{
    class Program
    {
        static void Main(string[] args)
        {
           oto();
        }

        public static void oto(){
            Otomobil oto = new Otomobil(5);
            oto.markaModel = Vasıta.markaModel.Bmw_520;
            oto.renk = ConsoleColor.DarkBlue;
            oto.Mod = Vasıta.mod.Sport;
            string surusmodu = oto.surusmodu(Vasıta.mod.Sport);
            Console.WriteLine("Marka ve Modeli:"+oto.markaModel+"\nRenk:"+oto.renk+"\nSürücü Modunu Seç:"+
            oto.Mod+"\n"+surusmodu);
        }
    }


}
