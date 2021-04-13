using System;

namespace batuhan_arac_odev.Araclar
{
    public class Otomobil : Vasıta
    {

        public markaModel markaModel { get; set; }

        public ConsoleColor renk { get; set; }

        public mod Mod { get; set; }
        public Otomobil(int kapı) : base(kapı)
        {
        }
        public Otomobil()
        {
            _tekerlek = 4;

        }


        public string surusmodu(mod a)
        {

            string b = Convert.ToString(a);

            if (b == "Comfort")
            {
                return "Konfor Moduna Geçildi..";
            }
            else if (b == "Sport")
            {
                return "Spor Moduna Geçildi..";
            }
            if (b == "Ecopro")
            {
                return "Tasarruf Moduna Geçildi..";
            }
            return "";
        }

    }
}