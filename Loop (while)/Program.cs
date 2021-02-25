using System;

namespace Loop__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Belirlenen komut bloğunu koşul sağlandığı sürece çalıştıran temel döngü yapılarından bir tanesidir. 
            //Döngü koşul deyimi true olduğu sürece çalıştırılır, koşul false olduğunda ise döngüden çıkılır.
            //While döngüsünde döngü değişkeni bulunmaz, bunun yerine while bloğuna girmeden başlangıçta değeri bilinen bir değişken kullanılır.

            int i = 1;

            while (i<=10)
            {
                Console.WriteLine("Hello");
                i++;
            }

        }
    }
}
