using YeniiMetrobus.Interface;

namespace YeniiMetrobus.Concrete
{
    public class IstanbulKart : IIstanbulKart
    {
        public string yolcuAd { get; set; }
        public int kartNo { get; set; }
        public double bakiye { get; set; }
        public karttipi kartTipi { get; set; }

    }
}