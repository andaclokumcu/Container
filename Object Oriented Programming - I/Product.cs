using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming___I
{
    class Product
    {
        //ürün tabanlı bir e-ticaret sitesi

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
