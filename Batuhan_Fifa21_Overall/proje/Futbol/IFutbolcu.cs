namespace proje.Futbol
{
    public interface IFutbolcu
    {
        int formaNumarasi { get; set; }

        string adSoyad { get; set; }

        Ozellikler ozellik { get; set; }
    }
    public class Ozellikler
    {
        public int sutGucu { get; set; }
        public int refleks { get; set; }
        public int agresiflik { get; set; }
        public int pasGucu { get; set; }
        public int hizlanma { get; set; }
        public int hiz { get; set; }


    }

    public abstract class Yetenekler
    {
        public abstract string sutCek();
        public abstract string sutKurtar();
        public abstract string pasAt();
    }
}