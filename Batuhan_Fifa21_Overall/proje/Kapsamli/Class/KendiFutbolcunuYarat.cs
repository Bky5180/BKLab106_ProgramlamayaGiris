using System;

namespace proje.Kapsamli.Class
{
    public class KendiFutbolcunuYarat : IDefans, Fiziksel, IAnaFutbolcuOzellikleri, Kaleci, Mental,
    MilliTakim, Pas, Sut, TakimBilgileri, TopKontrolu, OzelYetenekler, Ozelliklerr
    {
        #region Defansif Özellikler
        public int Markaj { get; set; }
        public int Kayma { get; set;}
        public int Mudahele { get; set;}
        #endregion

        #region Fiziksel Özellikler

        public int Hizlanma { get; set; }

        public int Dayaniklilik { get; set; }

        public int Guc { get; set; }

        public int Denge { get; set; }

        public int SprintHizi { get; set; }

        public int Ceviklik { get; set; }

        public int Ziplama { get; set; }
        #endregion

        #region Genel Özellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int GenelGuc { get; set; }
        public int Kilo { get; set; }
        public double Boy { get; set; }
        public int Yas { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string tercihEttiğiAyak { get; set; }
        public string pozisyon { get; set; }
        public string deger { get; set; }
        public string uyruk { get; set; }
        #endregion

        #region Kaleci Özellikler
        public int KaleciPozisyonu { get; set; }

        public int KLUcma { get; set; }

        public int KLTopKont { get; set; }

        public int KaleciVurus { get; set; }

        public int KaleciRefl { get; set; }

        #endregion

        #region Mental Özellikler
        public int Saldırganlık { get; set; }

        public int Reaksiyonlar { get; set; }

        public int AtakPoz { get; set; }

        public int TopKesmeler { get; set; }

        public int Görüs { get; set; }

        public int Soğukkanlilik { get; set; }
        #endregion

        #region Milli Takım Bilgileri
        public string milliTakimAdi { get; set; }
        public int formaNo { get; set; }
        public string oynadigiPozisyon { get; set; }
        public string cagrildigiDonemler { get; set; }
        public string maas { get; set; }
        #endregion

        #region Pas Özellikleri
        public int OrtaAcma { get; set; }

        public int KisaPas { get; set; }

        public int UzunPas { get; set; }
        #endregion

        #region Şut Özellikleri

        public int KafaVurusu { get; set; }

        public int SutGucu{ get; set; }

        public int Bitiricilik { get; set; }

        public int UzaktanSut { get; set; }

        public int Falso { get; set; }

        public int SVurIsabet { get; set; }

        public int Penalti { get; set; }

        public int Voleler{ get; set; }
        #endregion

        #region Takım Bilgileri
        public string takimAdi { get; set; }
        public int FormaNo { get; set; }
        public string OynadigiPozisyon{ get; set; }
        public DateTime katilmaTarihi { get; set; }
        public string sozlesmeSuresi { get; set; }
        public string Maas { get; set; }
        #endregion

        #region Top Kontrol Özellikleri
        public int TopKontrolu { get; set; }

        public int Dribling { get; set; }
        #endregion

        #region Özel Yetenekler
        public bool kule { get; set; }
        public bool UzunMenzilliSutor{ get; set; }
        public bool SonVurusUstasi { get; set; }
        public bool DriblingUstasi { get; set; }
        public bool SerbestVurusUstasi { get; set; }
        public bool Akrobat { get; set; }
        #endregion

        #region Özellikler
         public bool PlaseSut { get; set; }
        public bool AyaginDisiylaSut { get; set; }
        public bool SaglamOyuncu { get; set; }
        public bool AsirtmaSut { get; set; }
        public bool Füzeci { get; set; }
        public bool HizliDribling { get; set; }
        public bool OKurucu { get; set; }
        public bool TekKulupOyuncusu { get; set; }
        public bool TakimOyuncusu { get; set; }
        #endregion
    }
}