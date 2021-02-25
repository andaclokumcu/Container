using System;

namespace Explanation_of_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilen koşullara göre ilgili case bloğuna girer.Koşul ifadesi hangi case ile eşleşiyor ise o bloğa girer ve sonra switch bloğundan çıkar.

            int age = 19;

            switch (age)
            {
                case 3:
                    Console.WriteLine("Baby");
                    break;
                case 12:
                    Console.WriteLine("Child");
                    break;
                case 19:
                    Console.WriteLine("Young");
                    break;
                default:
                    Console.WriteLine(age);
                    break;
            }

            Console.ReadLine();
        }
    }
}
