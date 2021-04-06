using System;

namespace WinPersonelGiris.VeriGiris
{
    public struct Personel
    {
        public string Ad;
        public string soyad;
        string _tckimlik; //11 Haneli olup olmadigini kontol 
        public string gsm;
        public string email;
        public DateTime dogumtarihi;
        public Hobiler hobi;
        public Adres adres;

        public string SetTcKimlik(string tckimlik)
        {
            string str = "";
            if (tckimlik.Length == 11)
            {
                _tckimlik = tckimlik;
                str = "Ok";
            }
            else
            {
                str = "Verilen deger 11 karakter uzunlugunda degildir";
            }

            return str;
        }
        public string GetTcKimlik()
        {
            if (_tckimlik == null)
                return "TcKimlik Tanimli Degildir";
            else
                return "********"+_tckimlik.Substring(8);
        }
    }


   
}
