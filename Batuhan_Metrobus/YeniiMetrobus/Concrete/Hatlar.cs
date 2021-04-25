using YeniiMetrobus.Interface;
using System.Collections.Generic;

namespace YeniiMetrobus.Concrete
{
    public class Hatlar : IHatlar
    {
        public hatno HatNo { get; }
        public hatadi HatAdi { get; }
        public hatuzunlugu HatUzunlugu { get; }
        public istasyonsayisi IstasyonSayisi { get; }
        public sefersuresigidisdonus SeferSuresiGidisDonus { get; }
        public List<Duraklar> duraklar { get; set; }
    }
}