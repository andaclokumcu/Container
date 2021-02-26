using System;

namespace Ref_Parameter_Usage
{
    class Program
    {
        //Metodu tanımlarken referans yolu ile iletilmek istenen değişkenin önüne "ref" yazılmalıdır.
        //originalValue değişkeni metoda parametre olarak geçilmeden önce bir başlangıç değeri almak zorundadır,
        //"i" değişkeni metod içerisinde herhangi bir değişiklik yapmadan da kullanılabilir.
        static void Main(string[] args)
        {
            int originalValue = 43;

            Console.WriteLine("ChangeMethod'dan önce: " + originalValue);//Output 43

            ChangeMethod(1, 3, ref originalValue);

            Console.WriteLine("ChangeMethod'dan sonra: " + originalValue); //Output 47
        }

        static void ChangeMethod(int x, int y, ref int i)
        {
            i = i + x + y;//47
        }
    }
}
