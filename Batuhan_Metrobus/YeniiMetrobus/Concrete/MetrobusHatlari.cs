using YeniiMetrobus.Interface;
using System.Collections.Generic;

namespace YeniiMetrobus.Concrete
{
    public class MetrobusHatlari : IMetrobusHatlari, IHatlar, IDuraklar
    {
        public hatlar Hatlar { get; set; }
        public hatadi HatAdi { get; }
        public int durakId { get; }
        public durakad durakAd { get; }
        public hatno HatNo { get; }
        public hatuzunlugu HatUzunlugu { get; }
        public istasyonsayisi IstasyonSayisi { get; }
        public sefersuresigidisdonus SeferSuresiGidisDonus { get; }
        public List<Turnike> turnikeler { get; set; }
    }


}