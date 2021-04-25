using YeniiMetrobus.Interface;
using System.Collections.Generic;

namespace YeniiMetrobus.Concrete
{
    public class Duraklar : IDuraklar
    {
        public int durakId { get; }
        public durakad durakAd { get; }

        public List<Turnike> turnikeler { get; set; }

        public List<ParaUstuCihazi> paraUstuCihazlari { get; set; }
    }
}