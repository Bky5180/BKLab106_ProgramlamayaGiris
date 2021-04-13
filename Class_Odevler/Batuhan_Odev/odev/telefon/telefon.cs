using System;

namespace odev
{
    public class telefon
    {

        public telefon(){

            model = "model yok";
            uretimtarihi = DateTime.Now.Year;
        }

        public m marka {get; set;}

        public string model {get; set;}

        public ConsoleColor renk {get; set;}
        public akil akil {get; set;}

        public androios androİos {get; set;}

        public int ram {get; set;}

        public int hafiza {get; set;}

        

        public double ekran {get; set;}

        public int cozunurluk {get; set;}


        public int batarya {get; set;}

        public int uretimtarihi {get; set;}        

        public int garantisuresi {get; set;}

        decimal _fiyat;
         public decimal fiyat
         {
             get {return _fiyat;}
             set {
                 if (value >= 1000)
                 {
                     _fiyat = value;
                 }
             }

           
        }
       
    public kamera kamera {get; set;}
   
    }

 public class kamera{
        public int kamerasayisi {get; set;}

        public int kamerapx {get; set;}
    }
   
    public enum m{

        Apple,

        Samsung,

        Xiomi,

        Huawei,

        Sony,

        Vestel,

        Nokia,

        GeneralMobile,

        Reeder,
    }

   public enum akil{
       Akilli,

       Akilsiz,
   }

    public enum androios{
        Android,
        Ios,
    }
}