namespace proje.Futbol
{
    public class Forvet:Yetenekler, IFutbolcu
    {
        public int formaNumarasi { get; set; }

        public  string adSoyad { get; set; }
        public Ozellikler ozellik { get; set; }

        public override string sutCek()
        {
           return "Şut Çekildi";
        }
        public override string sutKurtar()
        {
           return "Şut Kurtarılmaya Çalışıldı";
        }
        public override string pasAt()
        {
           return "Pas Atılmaya Çalışıldı";
        }
    }
}