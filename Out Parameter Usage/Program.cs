using System;

namespace Out_Parameter_Usage
{
    class Program
    {
        //Metodu tanımlarken geçilmek istenen değişkenin önüne "out" yazılmalıdır.
        //originalValue değişkeni metoda parametre olarak geçilmeden önce bir başlangıç değeri almak zorunda değildir.
        //"i" değişkeni metod içerisinde herhangi bir değişiklik yapmadan kullanılamaz.


        static void Main(string[] args)
        {
            int originalValue = 43;

            ChangeMethod(1, 3, ref originalValue);

            Console.WriteLine("ChangeMethod'dan sonra: " + originalValue); //Output 47
        }

        static void ChangeMethod(int x, int y, ref int i)
        {
            i = i + x + y;//47
        }
    }
}
