using System;

namespace Cigkofteci.Cigkofteci
{
    public class Musteri:IMusteri
    {
        public string adSoyad{get; set;}
        public bool para{get; set;}
        public  bool corona{get; set;}

        public void cigkofteSatinAl(){
            if(para){
                Console.WriteLine("Bana Ordan 1 Acılı");
            }else{
                Console.WriteLine("Kardeşim Param Yok. Çok Açım :(");
            }
        }
    }
}