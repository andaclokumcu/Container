using System;
using System.Collections.Generic;

namespace MyList__Dictionary_
{
    class Program
    {
       
            static Dictionary<string, int> kutuphane = new Dictionary<string, int>();


            static void Main(string[] args)
            {
                kutuphane.Add("Andaç", 25);
                kutuphane.Add("Ayhan", 55);
                kutuphane.Add("Özlem", 49);
                kutuphane.Add("İpek", 20);

                foreach (var item in kutuphane)
                {
                    Console.WriteLine(item);
                }
            }
    }
}
