using System;

namespace Explanation_of_Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object Oriented Programming (Nesne Yönelimli Programlama): Her işlevin nesneler olarak soyutlandığı bir programlama yaklaşımıdır.
            //Nesnelerin birbirileriyle etkileşime geçmeleri sağlanmasıyla tasarlanır.
            //Gerçek hayatta gördüğümüz araba, radyo, bina…vb gibi nesnelerin bilgisayar ortamına aktarılmasına denir.
            //Örneğin lambanın açık - kapalı olması durumu, veya radyonun rengi, markası, üretim yılı… gibi özelliklerinın bilgisayar ortamında gösterilmesidir.

            //Gerçek dünyadaki nesnelerin tasarımları sınıf içinde yapılır.
            //Sınıftan nesne üretilip değişiklik yapılmak istendiğinde tüm programda değişiklik yapmak gerekmez sadece oluşturulan nesnenın sınıf içinde değişiklik yapmak yeterlidir.
            //Oluşturulan nesneler birbirinden bağımsız olduğu için bilgi gizleme olanağı artar.
            //-Örneğin A nesnesi B nesnesinin özelliklerini kullanamaz ve erişemez.
            //Nesne oluşturma bir sınıf içerisinde gerçekleştirilir ve bu kodlar başka projelerde kullanılabilir.
            //-Örneğin bir A nesnesi oluşturduysak bunu birçok yerde kullanabiliriz.
            //Sınıflar oluşturarak daha az kod oluşturup daha fazla iş yapıp kod tekarı önlenir.
            //-Örneğin insan sınıfında isim, soyisim, yaş… gibi özellikleri bir defa oluşturup istediğimiz kadar kullanabiliriz.
            //Kod tekrarı önlediği için geliştirme sürecinin verimliliğini artırır.

            //4 Temel Özellik --> 1.) Soyutlama (Abstraction)
            //2.) Kapsülleme(Encapsulation)
            //3.) Miras Alma(Inheritance)
            //4.) Çok biçimlilik(Polymorphism)

            //Abstraction: Bir sınıfta davranış ve özelliklerin tanımlanmasına soyutlama diyoruz.
            //-Örneğin araba sınıfında rengi, modeli, tekerlek sayısı, motor gücü, özellikleridir. Hızlanması, fren yapması, durması davranışlarıdır ve metotlar ile tanımlanır.

            //Encapsulation: Davranış ve özellikler sınıfta soyutlanarak kapsüllenir. Kapsülleme ile hangi özellik ve davranışın dışarıya sunulup sunulmayacağını belirleriz.
            //-Örneğin İnsan sınıfında yemek alışkanlığı bizi ilgilendirmiyorsa bunu kapalı (private) yapıp gizleriz. Ancak isim soyisim gibi bilgiler bizi ilgilendirdiği için bunlar açık bırakılır. Bu olaya bilgi saklama yani kapsülleme denilmektedir. Bilgi saklama erişim belirteçleri (public, private, protected) ile gerçekleştirilir.

            //public : herkesin kullanabileceği özellik ve davranışlardır
            //private : sadece kendi sınıfta kullanılabilen özellikler ve davranışlardır
            //protected : sınıf içinde ve miras alınan alt sınıflarda kullanılır.

            //Inheritance: Sınıflar birbirinden türeyebilir. Alt sınıf üst sınıfın özelliklerini alabilir.
            //-Örneğin araba ve bisiklet sınıflarında ortak özellik olarak tekerlek sayısı, hızı… gibi özelliklerini tekrar yazmak yerine bu özellikleri içeren bir sınıf oluşturup miras alabiliriz. Bir sınıftan birden fazla miraz alınıyorsa buna çoklu kalıtım denir.
            
            //Single Inheritance(Tekli Kalıtım): Alt sınıf tek bir üst sınıfın tüm özelliklerini taşır.
            //Multiple Inheritance(Çoklu Kalıtım): Bir alt sınıf birden fazla üst sınıfın tüm özelliklerini taşır. 
            //Multilevel Inheritance(Çok Seviyeli Kalıtım): Bir sınıfın alt sınıfı oluşturulduktan sonra bu alt sınfın da bir alt sınıfının oluşturulmasına denir.
            //Hierarchical Inheritance(Hiyerarşik Kalıtım): Bir üst sınıfın birden fazla alt sınıfa base class (temel sınıf)'lik yapmasına denir.
            //Hybrid Inheritance(Melez Kalıtım): Öbür Inheritance türlerinin 2 veya daha fazlasını barındıran Inheritance türüdür.


            //Polymorphism: Alt sınıflar üst sınıfın gösterdiği davranışları göstermek zorunda değildir. Alt sınıfların farklı davranışları göstermesine Çok biçimlilik denilmektedir.
            //-Örneğin Gemi ve araba sınıflarını ele aldığımızda bunların hareket tipleri bulunmaktadır. Gemi su üzerinden giderken araba karada hareket etmektedir. Kısaca farklı nesnelerin (araba ve gemi gibi) aynı olaya (hareket tipine) farklı şekilde cevap vermesidir.

        
    }
    }
}
