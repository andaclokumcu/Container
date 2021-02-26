using System;

namespace Technological_Products_Example__for_and_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Telefon";
            product1.productExplanation = "Akıllı Telefon";
            product1.productPrice = 4800;


            Product product2 = new Product();
            product2.productName = "Televizyon";
            product2.productExplanation = "UHD 110' TV";
            product2.productPrice = 6450;


            Product product3 = new Product();
            product3.productName = "Bulaşık Makinesi";
            product3.productExplanation = "4 Programlı Bulaşık Makinesi";
            product3.productPrice = 4999;


            Product product4 = new Product();
            product4.productName = "Buzdolabı";
            product4.productExplanation = "A++ Buzdolabı";
            product4.productPrice = 7200;

            Product[] products = { product1, product2, product3, product4 };


            Console.WriteLine("------For döngüsü ile ürünleri listeleme--------\n");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("\n" + (i + 1) + ". ürün bilgileri");
                Console.WriteLine("Ürün adı: " + products[i].productName + "\nÜrün açıklaması: " + products[i].productExplanation + "\nÜrün fiyatı: " + products[i].productPrice);

            }


            Console.WriteLine("\n\n------While döngüsü ile ürünleri listeleme--------\n");
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine("\n" + (j + 1) + ". ürün bilgileri");
                Console.WriteLine("Ürün adı: " + products[j].productName + "\nÜrün açıklaması: " + products[j].productExplanation + "\nÜrün fiyatı: " + products[j].productPrice);
                j++;
            }



            Console.WriteLine("\n\n------Foreach döngüsü ile ürünleri listeleme--------\n");
            foreach (Product product in products)
            {
                Console.WriteLine("\nÜrün adı: " + product.productName + "\nÜrün açıklaması: " + product.productExplanation + "\nÜrün fiyatı: " + product.productPrice);
            }
        }
    }
}
