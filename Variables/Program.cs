using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // string kategoriEtiketi = "Kategoriler"; --> Genellikle metinsel değerleri string içinde tanımlarız.
            // int ogrencisayisi = 32000; --> Tam sayı değerlerini böyle tanımlarız.
            // double faizoranı = 1,45; --> Çift duyarlı sayıları tanımlarken
            // bool sistemeGirisYapmisMi = false --> True ve false olarak değer alır. Genellikle kontrol işlmlerinde kullanılır.

            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }

        }
    }
}
