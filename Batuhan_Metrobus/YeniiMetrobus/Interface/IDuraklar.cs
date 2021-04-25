using System.Collections.Generic;
using YeniiMetrobus.Concrete;

namespace YeniiMetrobus.Interface
{
    public interface IDuraklar
    {
        int durakId { get; }
        durakad durakAd { get; }

        List<Turnike> turnikeler { get; set; }
    }

    public enum durakad
    {
        TÜYAP = 1,
        Beykent = 2,
        Cumhuriyet = 3,
        BeylikdüzüBelediye = 4,
        Beylikdüzü = 5,
        Güzelyurt = 6,
        Haramidere = 7,
        HaramidereSanayi = 8,
        SaadetdereMahallesi = 9,
        MustafaKemalpaşa = 10,
        CihangirÜniversiteMahallesi = 11,
        AvcılarMerkezÜniversiteKampüsü = 12,
        Şükrübey = 13,
        BüyükşehirBelediyesiSosyalTesisleri = 14,
        Küçükçekmece = 15,
        CennetMahallesi = 16,
        Florya = 17,
        Beşyol = 18,
        Sefaköy = 19,
        Yenibosna = 20,
        Şirinevler = 21,
        Bahçelievler = 22,
        İncirli = 23,
        Zeytinburnu = 24,
        Merter = 25,
        Cevizlibağ = 26,
        Topkapı = 27,
        BayrampaşaMaltepe = 28,
        Edirnekapı = 29,
        AyvansarayEyüpsultan = 30,
        Halıcıoğlu = 31,
        Okmeydanı = 32,
        DarülacezePERPA = 33,
        OkmeydanıHastane = 34,
        ÇağlayanAdliye = 35,
        Mecidiyeköy = 36,
        Zincirlikuyu = 37,
        OnBesTemmuzŞehitlerKöprüsü = 38,
        Burhaniye = 39,
        Altunizade = 40,
        Acıbadem = 41,
        Uzunçayır = 42,
        Fikirtepe = 43,
        Söğütlüçeşme = 44,
    }
}