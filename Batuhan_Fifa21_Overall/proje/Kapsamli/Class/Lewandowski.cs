using System;

namespace proje.Kapsamli.Class
{
    public class Lewandowski : IDefans, Fiziksel, IAnaFutbolcuOzellikleri, Kaleci, Mental,
    MilliTakim, Pas, Sut, TakimBilgileri, TopKontrolu, OzelYetenekler, Ozelliklerr
    {
        #region Defansif Özellikler
        public int Markaj { get => 50; }
        public int Kayma { get => 19; }
        public int Mudahele { get => 42; }
        #endregion

        #region Fiziksel Özellikler
        public int Hizlanma { get => 77; }

        public int Dayaniklilik { get => 76; }

        public int Guc { get => 86; }

        public int Denge { get => 82; }

        public int SprintHizi { get => 79; }

        public int Ceviklik { get => 77; }

        public int Ziplama { get => 84; }
        #endregion

        #region Genel Özellikler
        public string Ad { get => "Robert"; }
        public string Soyad { get => "Lewandowski"; }
        public int Kilo { get => 81; }
        public double Boy { get => 1.85; }
        public int GenelGuc { get => 92; }
        public int Yas { get => 32; }
        public DateTime dogumTarihi { get => Convert.ToDateTime("21-08-1988"); }
        public string tercihEttiğiAyak { get => "Sağ"; }
        public string pozisyon { get => "SNT"; }
        public string deger { get => "€124.500.000"; }
        public string uyruk { get => "Polonya"; }
        #endregion

        #region Kaleci Özellikler
        public int KaleciPozisyonu { get => 8; }

        public int KLUcma { get => 15; }

        public int KLTopKont { get => 6; }

        public int KaleciVurus { get => 12; }

        public int KaleciRefl { get => 10; }

        #endregion

        #region Mental Özellikler
        public int Saldırganlık { get => 81; }

        public int Reaksiyonlar { get => 93; }

        public int AtakPoz { get => 95; }

        public int TopKesmeler { get => 49; }

        public int Görüs { get => 81; }

        public int Soğukkanlilik { get => 88; }
        #endregion

        #region Milli Takım Bilgileri
        public string milliTakimAdi { get => "Polonya"; }
        public int formaNo { get => 9; }
        public string oynadigiPozisyon { get => "SNT"; }
        public string cagrildigiDonemler { get => "2010/2011/2012/2016/2017/2018/2019/2020/2021"; }
        public string maas { get => "€270.000"; }
        #endregion

        #region Pas Özellikleri
        public int OrtaAcma { get => 71; }

        public int KisaPas { get => 85; }

        public int UzunPas { get => 70; }
        #endregion

        #region Şut Özellikleri

        public int KafaVurusu { get => 90; }

        public int SutGucu { get => 90; }

        public int Bitiricilik { get => 95; }

        public int UzaktanSut { get => 87; }

        public int Falso { get => 79; }

        public int SVurIsabet { get => 85; }

        public int Penalti { get => 90; }

        public int Voleler { get => 89; }
        #endregion

        #region Takım Bilgileri
        public string takimAdi { get => "FC Bayern Münich"; }
        public int FormaNo { get => 9; }
        public string OynadigiPozisyon { get => "SNT"; }
        public DateTime katilmaTarihi { get => Convert.ToDateTime("01-07.2014"); }
        public string sozlesmeSuresi { get => "2023"; }
        public string Maas { get => "€20.000.000"; }
        #endregion

        #region Top Kontrol Özellikleri
        public int TopKontrolu { get => 88; }

        public int Dribling { get => 85; }
        #endregion

        #region Özel Yetenekler
        public bool kule { get => true; }
        public bool UzunMenzilliSutor { get => true; }
        public bool SonVurusUstasi { get => true; }
        public bool DriblingUstasi { get => false; }
        public bool SerbestVurusUstasi { get => false; }
        public bool Akrobat { get => false; }
        #endregion

        #region Özellikler
        public bool PlaseSut { get => true; }
        public bool AyaginDisiylaSut { get => true; }
        public bool SaglamOyuncu { get => true; }
        public bool AsirtmaSut { get => true; }
        public bool Füzeci { get=>false; }
        public bool HizliDribling { get=>false; }
        public bool OKurucu { get=>false; }
        public bool TekKulupOyuncusu { get=>false; }
        public bool TakimOyuncusu { get=>false; }
        #endregion
    }
}