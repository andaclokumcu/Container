using System;

namespace Customer_Tracking_Example_in_a_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Andaç"; musteri1.Surname = "Lokumcu";
            musteri1.ID = 123;
            Musteri musteri2 = new Musteri();
            musteri2.Name = "İpek";
            musteri2.Surname = "Lokumcu";
            musteri2.ID = 456;
            Musteri musteri3 = new Musteri();
            musteri3.Name = "Buse";
            musteri3.Surname = "Doğu";
            musteri3.ID = 789;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Guncelle(musteri3);
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.Listele(musteriler);
        }
    }
}
