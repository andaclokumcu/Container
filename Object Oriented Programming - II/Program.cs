using System;

namespace Object_Oriented_Programming___II
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TCNo = "12345678901";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
      //Eğer bir yerde 'new' varsa referans numarası vardır. Musteri sınıfı hem kişisel hem şirket müsterisinin referansını tutabiliyor.
            Musteri musteri4 = new TuzelMusteri();



        }
    }
}
