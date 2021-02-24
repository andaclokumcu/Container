using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun) //Urun classı içindeki seçilen urun'u bir emir işlemi gibi gerçekleştirir. Geriye değer döndürmezler.
            //Sonuç veren metod.
        {
        Console.WriteLine("Tebrikler, ürün sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat) //Ürün hakkındaki özelliklere girerek de ekleme yapabiliriz.
        {
        Console.WriteLine("Tebrikler, ürün sepete eklendi : " + urunAdi);
        }

  }
}
