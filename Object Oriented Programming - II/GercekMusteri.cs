using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming___II
{
    //GercekMusteri:Musteri -->Bu olaya inheritance(miras alma) diyoruz. Tuzel müşteri bir müşteridir demek.
    class GercekMusteri :Musteri
    {
        //Individual
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string TCNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
