using System;

namespace Cigkofteci.Cigkofteci
{
    public class Kemal : IPersonel, ISicakKanlilik
    {
        public int yas { get=>34; }
        public string adSoyad { get=>"Kemal Mladze"; }
        public bool sabika { get=>false; }
        public bool adres { get=>true; }
        public string saglikDurumu { get=>"Sağlıklı"; }

        public bool musterilereYardimciOl{get=>true;}
        
        public string cigKofteYogurma(){

           return "Kemal Çiğköfte Yoğurdu";
        }
       public string hesKoduTara(IMusteri musteri){
           if(musteri.corona){
               return "Koronasınız. Lütfen Karantinaya Dönün";
           }else{
               return "Hoşgeldiniz";
           }
        }
        public void sohbetEt(IPersonel personel){
             Console.WriteLine("Kemal "+personel.adSoyad+"le sohbet ediyor");
         }
         public void yardimciOl(IPersonel personel){

             Console.WriteLine("Kemal "+personel.adSoyad+"e yardımcı oldu");
         }
        public string cigKofteSat(IMusteri musteri){
            if(!musteri.corona){
                if(musteri.para){
                    return "Dürümünüz Hazır. Afiyet Olsun";
                }else{
                    if(musterilereYardimciOl){
                        return"Afiyet Olsun Kardeşim";
                    }else{
                            return"Parasız Mal Yok. Başka Kapıya!";
                    }
                }
            }else{
                return "Koronasınız. Evinize Gidin";
            }
        }
    }
}