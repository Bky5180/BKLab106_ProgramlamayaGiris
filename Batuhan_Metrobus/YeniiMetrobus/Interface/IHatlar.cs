namespace YeniiMetrobus.Interface
{
    public interface IHatlar
    {
        hatno HatNo { get; }
        hatadi HatAdi { get; }

        hatuzunlugu HatUzunlugu { get; }
        istasyonsayisi IstasyonSayisi { get; }
        sefersuresigidisdonus SeferSuresiGidisDonus { get; }
    }

    public enum hatadi
    {
        AvcilarZincirlikuyu = 1,
        AvcilarSogutlucesme = 2,
        BeylikduzuCevizlibag = 3,
        BeylikduzuZincirlikuyu = 4,
        SogutlucesmeEdirnekapi = 5,
        BeylikduzuAvcilar = 6,
        AvcılarŞehitmustafacambaz = 7,
        UzunçayırZincirlikuyu = 8,
    }

    public enum hatno
    {
        OtuzDört = 1,
        OtuzDörtAS = 2,
        OtuzDortBZ = 3,
        OtuzDortC = 4,
        OtuzDortA = 5,
        OtuzDortB = 6,
        OtuzDortT = 7,
        OtuzDortU = 8,
    }
    public enum hatuzunlugu
    {
        OtuzKm = 1,
        KirkIkiKm = 2,
        KirkKm = 3,
        YirmiDokuzKm = 4,
        YirmiBirKm = 5,
        Dokuz_YediKm = 6,
        OnSekiz_İkiKm = 7,
        SekizKm = 8,
    }
    public enum istasyonsayisi
    {
        YirmiAlti = 1,
        OtuzUc = 2,
        OtuzYedi = 3,
        YirmiAltı = 4,
        OnDokuz = 5,
        OnBir = 6,
        OnBes = 7,
        Alti = 8,
    }
    public enum sefersuresigidisdonus
    {
        YuzYirmiDk = 1,
        YuzAltmisUcDk = 2,
        YuzAltmisDk = 3,
        YuzYirmıDk = 4,
        DoksanDk = 5,
        KirkBesDk = 6,
        YetmisDk = 7,
        ElliDk = 8,
    }
}