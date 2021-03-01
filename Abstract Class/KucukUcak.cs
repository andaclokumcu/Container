using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    class KucukUcak : Ucak
    {
        public override void UcakFiyati()
        {
//Ucak Abstract Class’ından kalıttığımız BuyukUcak ve KucukUcak sınıflarında, UcakFiyati Abstract Method’unu override ederek gövdesini dolduruyoruz.
//İçerisine ise Büyük Uçağın ve Küçük Uçağın temsili fiyatlarını Console’a yazdırıyoruz.
            
            Console.WriteLine("Küçük Uçağın Fiyatı: 3M$");
            Console.ReadLine();
        }
    }
}
