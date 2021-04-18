namespace Cigkofteci.Cigkofteci
{
    public interface IDukkan
    {
         bool masa{get;}
         bool sandalye{get;}
         bool cigkofte{get;}
         bool personel {get;}

         void cigkofteUret(IPersonel personel);
         void cigkofteSat(Kemal personel, IMusteri musteri);
         void cigkofteSat(Mahmut personel, IMusteri musteri);

         void hesKodu(IPersonel personel, IMusteri musteri);
    }
}