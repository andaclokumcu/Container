using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
//Son olarak ise Ucak Abstract sınıfından kalıtılan KucukUcak sınıfından oluşturduğumuz “k” nesnesini kullanarak UcakFiyati methodunu çalıştırıyoruz.
            
            KucukUcak k = new KucukUcak();
            k.UcakFiyati();
        }
    }
}
