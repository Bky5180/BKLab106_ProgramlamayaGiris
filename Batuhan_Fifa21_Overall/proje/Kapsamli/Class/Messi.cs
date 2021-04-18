using System;

namespace proje.Kapsamli.Class
{
    public class Messi : IDefans, Fiziksel, IAnaFutbolcuOzellikleri, Kaleci, Mental,
    MilliTakim, Pas, Sut, TakimBilgileri, TopKontrolu, OzelYetenekler, Ozelliklerr
    {
        #region Defansif Özellikler
        public int Markaj { get => 32; }
        public int Kayma { get => 24; }
        public int Mudahele { get => 35; }
        #endregion

        #region Fiziksel Özellikler

        public int Hizlanma { get => 91; }

        public int Dayaniklilik { get => 72; }

        public int Guc { get => 69; }

        public int Denge { get => 95; }

        public int SprintHizi { get => 80; }

        public int Ceviklik { get => 91; }

        public int Ziplama { get => 68; }
        #endregion

        #region Genel Özellikler
        public string Ad { get => "Lionel"; }
        public string Soyad { get => "Messi"; }
        public int GenelGuc { get => 93; }
        public int Kilo { get => 72; }
        public double Boy { get => 1.70; }
        public int Yas { get => 33; }
        public DateTime dogumTarihi { get => Convert.ToDateTime("24-06-1987"); }
        public string tercihEttiğiAyak { get => "Sol"; }
        public string pozisyon { get => "SĞK-SNT-OF"; }
        public string deger { get => "€103.500.000"; }
        public string uyruk { get => "Arjantin"; }
        #endregion

        #region Kaleci Özellikler
        public int KaleciPozisyonu { get => 14; }

        public int KLUcma { get => 6; }

        public int KLTopKont { get => 11; }

        public int KaleciVurus { get => 15; }

        public int KaleciRefl { get => 8; }

        #endregion

        #region Mental Özellikler
        public int Saldırganlık { get => 44; }

        public int Reaksiyonlar { get => 94; }

        public int AtakPoz { get => 93; }

        public int TopKesmeler { get => 40; }

        public int Görüs { get => 95; }

        public int Soğukkanlilik { get => 96; }
        #endregion

        #region Milli Takım Bilgileri
        public string milliTakimAdi { get => "Arjantin"; }
        public int formaNo { get => 10; }
        public string oynadigiPozisyon { get => "SĞK"; }
        public string cagrildigiDonemler { get => "2009/2010/2011/2012/2013/2014/2015/2016/2017/2018/2019/2020/2021"; }
        public string maas { get => "€560.000"; }
        #endregion

        #region Pas Özellikleri
        public int OrtaAcma { get => 85; }

        public int KisaPas { get => 91; }

        public int UzunPas { get => 91; }
        #endregion

        #region Şut Özellikleri

        public int KafaVurusu { get => 70; }

        public int SutGucu { get => 86; }

        public int Bitiricilik { get => 95; }

        public int UzaktanSut { get => 94; }

        public int Falso { get => 93; }

        public int SVurIsabet { get => 94; }

        public int Penalti { get => 75; }

        public int Voleler { get => 88; }
        #endregion

        #region Takım Bilgileri
        public string takimAdi { get => "FC Barcelona"; }
        public int FormaNo { get => 10; }
        public string OynadigiPozisyon { get => "OF"; }
        public DateTime katilmaTarihi { get => Convert.ToDateTime("01-07.2004"); }
        public string sozlesmeSuresi { get => "2021"; }
        public string Maas { get => "€71.000.000"; }
        #endregion

        #region Top Kontrol Özellikleri
        public int TopKontrolu { get => 96; }

        public int Dribling { get => 96; }
        #endregion

        #region Özel Yetenekler
        public bool kule { get => false; }
        public bool UzunMenzilliSutor { get => true; }
        public bool SonVurusUstasi { get => true; }
        public bool DriblingUstasi { get => true; }
        public bool SerbestVurusUstasi { get => true; }
        public bool Akrobat { get => true; }
        #endregion

        #region Özellikler
        public bool PlaseSut { get => true; }
        public bool AyaginDisiylaSut { get => true; }
        public bool SaglamOyuncu { get => true; }
        public bool AsirtmaSut { get => true; }
        public bool Füzeci { get=>true; }
        public bool HizliDribling { get=>true; }
        public bool OKurucu { get=>true; }
        public bool TekKulupOyuncusu { get=>true; }
        public bool TakimOyuncusu { get=>true; }
        #endregion
    }
}