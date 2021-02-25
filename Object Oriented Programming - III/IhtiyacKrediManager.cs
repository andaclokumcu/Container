using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming___III
{
    class IhtiyacKrediManager : IKrediManager  //inheritance //ampulden implement inheritance 

    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
