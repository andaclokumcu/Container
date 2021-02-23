using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs(); //Kurs sınıfından ilk verileri çağırdık.
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen + ":" + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1 }; 
  //Başka kursları, eğitmenlerini ve izlenme oranını Kurs sınıfı içindeki verilerden kurs2,kurs3 olarak tanımlayıp devam edebiliriz.
             
        }
    }
}
