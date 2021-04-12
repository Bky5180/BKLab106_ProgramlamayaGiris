using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.Telefon
{
    public class OnurOzAkilliTelefon
    {
        public OnurOzAkilliTelefon()
        {
            Fiyat = 200;
            Yazilim = Yazilim.Android;
            Renk = Color.Black; 

        }
       
        public decimal Fiyat { get; set; }
        public string Islemci { get; set; }
        public string Marka { get; set; }
        public int Yil { get; set; }
        public string Model { get; set; }
        public string Ram { get; set; }

        public string Ekran { get; set; }
        public  int DepolamaAlani { get; set; }
        public string Batarya { get; set; }

        public string Kamera { get; set; }
        public Yazilim Yazilim { get; set; }
        public bool NFC { get; set; }
        public Color Renk { get; set; }
    }
    public enum Yazilim
    {
        Android,
        IOS,
        Symbian,
        Windows,
    }
    public enum Marka
    {
        Nokia,
        Samsung,
        LG,
        Sony,
        Motorala,
        Apple,
        HTC,
        Huawei,
        Wikoo,


    }

}   


