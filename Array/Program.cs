using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "C#";
            string kurs2 = "Python"; //C#,Python ve Java olarak 3 kurs tanımladık.
            string kurs3 = "Java";

            string[] kurslar = new string[] { "C#", "Python", "Java" };  //kurslar adında bütün kursları barındıran tanım yapıldı.

            for (int i = 0; i < kurslar.Length; i++) //0.elemandan başlayarak kursları uzunluğunca ekrana ver.
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yarar yani kursları tek tek dolaşır.
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
