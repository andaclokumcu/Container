using System;
using System.Collections.Generic;

namespace Dictionary_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(134, "Tolga Demirer");
            Ogrenci.Add(158, "Ümit Özkan");
            Ogrenci.Add(115, "Kadir Aydemir");
            Ogrenci.Add(174, "Cemal Çiftçi");
            Console.Write("Öğrenci No Giriniz:");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }

//Yukarıdaki örneğimizi açıklayacak olursak; Öğrenci numarası girildiğinde, ilgili öğrencinin adı - soyad bilgilerini ekrana yazdıran bir uygulama hazırladık. 
//Öğrencinin numarasını Anahtar, ad - soyad bilgisini de Değer olarak tuttuk.Bu yüzden Anahtarın veri tipini int, Değerin veri tipini de string olarak belirttik.

//Klavyeden girilen numarada bir öğrenci koleksiyon içerisinde mevcut ise ad-soyad bilgileri ekrana yazdırılacaktır.
//Eğer mevcut değilse “KeyNotFoundException” şeklinde bir hata döndürecektir, bu durumda try bloğu içerisinde çıkıp, catch bloğu içerisine girecektir program ve ekrana “Öğrenci Bulunamadı” yazacaktır.
        }
    }
}
