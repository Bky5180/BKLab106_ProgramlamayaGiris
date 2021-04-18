using System;

namespace Cigkofteci.Cigkofteci
{
    public class Mahmut : IPersonel, ISicakKanlilik
    {
        public int yas { get => 28; }
        public string adSoyad { get => "Mahmut Paydemir"; }
        public bool sabika { get => false; }
        public bool adres { get => true; }
        public string saglikDurumu { get => "Sağlıklı"; }
        public bool musterilereYardimciOl{get=>false;}
        public  void sohbetEt(IPersonel personel){
            Console.WriteLine("Mahmut "+personel.adSoyad+"yle sohbet ediyor");
        }
        public   void yardimciOl(IPersonel personel){
           Console.WriteLine("Mahmut "+personel.adSoyad+"ye yardımcı oldu");
        }
        public string cigKofteYogurma()
        {
            return "Mahmut Çiğköfte Yoğurdu";
        }

      public string hesKoduTara(IMusteri musteri){
          if(musteri.corona){
              return "Koronasın. Evine Dön!";
          }else{
              return "Hoşgeldiniz Efendim";
          }
        }
        public string cigKofteSat(IMusteri musteri){
            if(!musteri.corona){
                if(musteri.para){
                    return "Afiyet Olsun Efendim";
                }else{
                    if(musterilereYardimciOl){
                        return "Afiyet Olsun";
                    }else{
                        return "Elin Ayağın Tutuyor. Git Çalış";
                    }
                }
            }else{
                return "Coronasınız. Size Ürün Satamam.";
            }
        }
    }
}