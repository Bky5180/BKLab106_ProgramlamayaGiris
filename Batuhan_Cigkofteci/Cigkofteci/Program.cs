using System;
using Cigkofteci.Cigkofteci;

namespace Cigkofteci
{
    class Program
    {
        static void Main(string[] args)
        {
            Dukkan dukkan = new Dukkan();
           Kemal kemal = new Kemal();
           Mahmut mahmut = new Mahmut();
           Musteri sevan = new Musteri();

           sevan.adSoyad = "Sevan Portyan";
           sevan.corona = true;
           sevan.para = false;

           dukkan.cigkofteUret(kemal);
           dukkan.cigkofteUret(mahmut);

           kemal.yardimciOl(mahmut);
           kemal.sohbetEt(mahmut);

           dukkan.hesKodu(mahmut,sevan);
           dukkan.hesKodu(kemal,sevan);

           dukkan.cigkofteSat(kemal,sevan);
           dukkan.cigkofteSat(mahmut,sevan);
        }
    }
}