using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    class BuyukUcak : Ucak
    {
        public override void UcakFiyati()
        {
            Console.WriteLine("Büyük Uçağın Fiyatı: 5M$");
            Console.ReadLine();
        }
    }
    
}
