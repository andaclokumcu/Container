using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming___II
{
    //TuzelMusteri:Musteri -->Bu olaya inheritance(miras alma) diyoruz. Tuzel müşteri bir müşteridir demek.
    class TuzelMusteri :Musteri
    {
        //Coorporate Customer
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
