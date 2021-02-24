using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming___I
{
    class ProductManager
    {
        //void ile git ekle, git günclle gibi emirleri vererek işlem yaptırıyoruz.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName +" "+ "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
        

    }
}
