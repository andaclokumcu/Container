using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Tracking_Example_in_a_Bank
{
    class MusteriManager
    {
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("İsim : " + musteri.Name + " Soyisim : " + musteri.Surname + " ID : " + musteri.ID);
            }
        }

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " isimli müşteri eklendi");
        }

        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " isimli müşteri güncellendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " isimli müşteri silindi!");
        }
    }
}
