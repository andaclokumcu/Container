using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    abstract class Ucak
    {
//Bizim Ucak adında bir tane Abstract(taban) sınıfımız olacak.Ve daha sonra bu Abstract Class’dan BuyukUcak ve KucukUcak sınıflarını kalıtacağız. 
//Ve Ucak Abstract Class’ımızın içerisine basit bir “UcakFiyatı” isimli method yazıp, bu method’u kalıttığımız Class’larda override ederek, 
//UcakFiyatı isimli methodumuza gövdeyi implement edeceğiz.
        public int YolcuKapasitesi { get; set; }
        public string UcakSirketi { get; set; }
        //Ucak’ların ortak Özellikleri’leri

        public abstract void UcakFiyati();
        //override edilecek abstract methodumuz

//Abstract Class’ımızda, sonradan oluşturulabilecek Ucak Class’larının ortak özellikleri ve bir tane override ederek gövdesini oluşturacağımız bir Abstract Method var.
    }
}
