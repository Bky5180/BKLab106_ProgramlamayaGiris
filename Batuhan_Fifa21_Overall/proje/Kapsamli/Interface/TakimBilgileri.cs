using System;

namespace proje.Kapsamli
{
    public interface TakimBilgileri
    {
        string takimAdi { get; }
        int FormaNo { get; }
        string OynadigiPozisyon { get; }
        DateTime katilmaTarihi { get; }
        string sozlesmeSuresi { get; }
        string Maas { get; }
    }
}