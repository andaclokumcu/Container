using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming___II
{
    class Musteri
    {
        //bir banka üzerinden
        //class'ların özelliği içinde özellik ve operasyon barındırmalarıdır.Ama ikisi aynı sınıfta bulunamaz.

        //public int Id { get; set; }
        //public string MusteriNo { get; set; }
        //public string Adi { get; set; }
        //public string Soyadi { get; set; }
        //public string SirketAdi { get; set; }
        //public string TCNo { get; set; } 
        //TCNo ve VergiNo string tanımlanmasının sebebi bir matematiksel işlem gerektirmemesi sadece veri girişi olacağı için
        //public string VergiNo { get; set; }

        //Yukarıdaki gibi bir sınıflandırma bireysel ve tüzel(şirket) müşterilerin bilgilerinin karışma ihtimali mevcut

        public int Id { get; set; }
        public string MusteriNo { get; set; }

    }
}
