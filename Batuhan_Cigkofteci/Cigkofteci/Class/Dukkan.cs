using System;

namespace Cigkofteci.Cigkofteci
{
    public class Dukkan:IDukkan
    {
        public bool masa{get=>true;}
        public bool sandalye{get=>true;}
        public bool cigkofte{get=>true;}
        public bool personel{get=>true;}

        public void cigkofteUret(IPersonel personel){

            Console.WriteLine(personel.cigKofteYogurma());
        }

       public void cigkofteSat(Kemal personel, IMusteri musteri){
           
           Console.WriteLine(personel.cigKofteSat(musteri));
       }
        public void cigkofteSat(Mahmut personel, IMusteri musteri){
          Console.WriteLine(personel.cigKofteSat(musteri));
       }

       public void hesKodu(IPersonel personel, IMusteri musteri){
           Console.WriteLine(personel.hesKoduTara(musteri));
       }
    }
}