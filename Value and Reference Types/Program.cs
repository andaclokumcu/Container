using System;

namespace Value_and_Reference_Types
{
    class Program
    {
        static void Main(string[] args)
        {  // int, decimal, float, double, bool --> değer (value) tipi
           // array, class, interface --> referans (referance) tipi

            //C#’ta nesnelerin ram üzerinde tutulabileceği iki yer vardır.
            //STACK: Değer tipi olan değişkenler burada tanımlanır.
            //Thread’in çalışması sürecinde kullanılan memory bölümüdür.Metod içerisinde tanımlanan değişkenler, pointer’lar burada tutulur.
            //Metod işini bitirip return olduğu zaman, memory’de ayrılan bu stack alanı yeni ihtiyaçlarda kullanılmak üzere boşaltılır.

            //HEAP: Referans tipi olan değişkenler burada tanımlanır. Dinamik olarak nesnelerin tuttulduğu bölümdür.

            int sayi1 = 10;
            int sayi2 = 30;   //sayi1= 10 değil artık 30'dur
            sayi1 = sayi2;    //sayi2= 30 değil artık 65'tir.
            sayi1 ???        //yani sayı1= 30 kalır. Değer old. için ayrı ayrı ele alınır. 

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1=sayilar2 //yani sayilar1'in referans numarası sayilar2'ye eşit oluyor. 
            sayilar2[0]=999
            sayilar1[0] ???

                //stack                   //heap
                sayilar1    ---->        [10,20,30]      //sayilar1 heap oku sayilar2'ye eşitlediğimiz için iptal olur.
                sayilar2    ---->       [100,200,300]    //sayilar1[0]=999
        }
    }
}
