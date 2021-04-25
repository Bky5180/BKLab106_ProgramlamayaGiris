namespace YeniiMetrobus.Interface
{
    public interface IIstanbulKart
    {
        string yolcuAd { get; set; }
        int kartNo { get; set; }
        double bakiye { get; set; }

        karttipi kartTipi { get; set; }
    }

    public enum karttipi
    {
        Ogrenci,
        Ogretmen,
        SaglikCalisani,
        Normal,
    }
}