using System;

namespace Dolar_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalıs");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis");
            }
            else
            {
                Console.WriteLine("Degismedi");

            }
        }
    }
}
