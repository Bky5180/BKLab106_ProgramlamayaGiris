using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class OK_Telefon
    {
        public OK_Telefon()
        {
            Tipi = 0;
        }
        public Tipi Tipi { get; set; }
        public string Mensei { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Seri { get; set; }
        public DateTime CikisYili { get; set; }
        public double Fiyat { get; set; }
        public string Satici { get; set; }
    }
    public struct DigerOzellikler
    {
        public float SarDegeriBas { get; set; }
        public float SarDegeriVucut { get; set; }
        public Aksesuar Aksesuar { get; set; }
        public bool CiftHat { get; set; }
        public bool YuzTanima { get; set; }
        public bool ParmakİziSensoru { get; set; }
        public bool SuyaDayaniklilik { get; set; }
        public bool TozaDayaniklilik { get; set; }

    }
    public class OperatingSystem
    {
        public IsletimSistemi IsletimSistemi { get; set; }
        public string OS_MevcutSurum { get; set; }
        public string OS_UpgradeSurum { get; set; }
        public string UI_MevcutSurum { get; set; }
        public string UI_UpgradeSurum { get; set; }
    }
    public class NetworkWifiMedya
    {
        public bool AgTeknolojisi { get; set; }
        public string WiFi { get; set; }
        public bool NFC { get; set; }
        public bool Bluetooth { get; set; }
        public float BluetoothVersion { get; set; }
        public bool Radyo { get; set; }
    }
    public class Tasarim
    {
        public Color Renk { get; set; }
        public float Agirlik { get; set; }
        public Boyutlar Boyutlar { get; set; }
    }
    public class TemelDonanim
    {
        public string Islemci { get; set; }
        public float IslemciHizi { get; set; }
        public byte CpuCekirdek { get; set; }
        public byte Ram { get; set; }
        public string RamTipi { get; set; }
        public short DahiliHafiza { get; set; }
        public bool HafizaKartiDestegi { get; set; }
        public short HafizaKarti { get; set; }
    }
    public class Kamera
    {
        public short ArkaKamera { get; set; }
        public ArkaKameraTipi ArkaKameraTipi { get; set; }
        public byte OnKamera { get; set; }
        public int VideoCozunurluk { get; set; }
    }
    public class Batarya
    {
        public short BataryaKapasitesi { get; set; }
        public byte KonusmaSuresi { get; set; }
        public byte BeklemeSuresi { get; set; }
        public UsbGiris UsbGiris { get; set; }
        public bool HizliSarj { get; set; }
        public bool DegisirBatarya { get; set; }
        public byte HizliSarjGucu { get; set; }
    }
    public class Ekran
    {
        public float EkranBoyutu { get; set; }
        public EkranTeknolojisi EkranTeknolojisi { get; set; }
        public int EkranCozunurluk { get; set; }
        public short EkranYenilemeHizi { get; set; }
        public float EkranGovdeOrani { get; set; }
    }
    public enum Tipi
    {
        Akilli,
        Tuslu
    }
    public enum Aksesuar
    {
        MikrofonluKulaklik,
        EkranKoruyucu,
        TelefonKilifi,
        TemizlikKiti,
        AracKiti,
        SelfieCubugu
    }
    public enum Boyutlar
    {
        Boy,
        En,
        Kalinlik
    }
    public enum UsbGiris
    {
        MicroUSB,
        TypeC,
        Lightning,
        InceKalinUclu
    }
    public enum ArkaKameraTipi
    {
        IkinciKamera,
        UcuncuKamera,
        DorduncuKamera
    }
    public enum IsletimSistemi
    {
        Android,
        iOS,
        HarmonyOS,
        BlackBerryOS,
        WindowsMobile,
        Diger
    }
    public enum EkranTeknolojisi
    {
        AMOLED,
        SuperAMOLED,
        DynamicAMOLED,
        IPS,
        LCD,
        OLED,
        PLS,
        CorningGorillaGlass,
        HD,
        FullHD,
        Retina
    }
}