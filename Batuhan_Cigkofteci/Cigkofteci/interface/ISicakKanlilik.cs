namespace Cigkofteci.Cigkofteci
{
    public interface ISicakKanlilik
    {
         bool musterilereYardimciOl{get;}
         void sohbetEt(IPersonel personel);
         void yardimciOl(IPersonel personel);
         
    }
}