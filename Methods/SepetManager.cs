using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
        Console.WriteLine("Tebrikler, ürün sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string Aciklama, double Fiyati)
        {
        Console.WriteLine("Tebrikler, ürün sepete eklendi : " + urunAdi);
        }

  }
}
