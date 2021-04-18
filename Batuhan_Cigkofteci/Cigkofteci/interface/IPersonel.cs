namespace Cigkofteci.Cigkofteci
{
    public interface IPersonel
    {
         int yas {get;}
         string adSoyad{get;}
         bool sabika{get;}
         bool adres{get;}
         string saglikDurumu{get;}
         
         string hesKoduTara(IMusteri musteri);
         string cigKofteYogurma();

         string cigKofteSat(IMusteri musteri);
    }
}