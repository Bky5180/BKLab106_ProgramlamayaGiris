using System;

namespace proje.Kapsamli
{
    public interface IAnaFutbolcuOzellikleri
    {
        string Ad { get; }
        string Soyad { get; }
        int Kilo { get; }
        double Boy { get; }
        int Yas { get; }
        int GenelGuc {get;}
        DateTime dogumTarihi { get; }
        string tercihEttiğiAyak { get; }
        string pozisyon { get; }
        string deger { get; }
        string uyruk { get; }

    }
}