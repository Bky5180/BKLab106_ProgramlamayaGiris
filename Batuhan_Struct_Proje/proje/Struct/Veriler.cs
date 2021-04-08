using System;

namespace proje
{

    struct Veri
    {
        public string ad, mesaj, deger;

        string tc;

        public string [] personel;

       
      

        public string tcKontrol(string a)
        {   
            
            long b = 0;
            string mesaj = null;
            if (Int64.TryParse(a, out b))
            {


                if (a.Length == 11)
                {

                    mesaj = "Doğru";

                    if (tc == a)
                    {
                        mesaj = "Kayıt Var";
                    }
                    else
                    {
                        tc = a;
                    }
                }
                else
                {
                    mesaj = "Lütfen 11 Hane Giriniz";
                }
            }
            else
            {
                mesaj = "Lütfen Sayı Giriniz";
            }
            return mesaj;
        }

        public string tcGonder()
        {



            return tc;
        }
    }

}