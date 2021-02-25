using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming___III
{
    //class KrediManager --> burada opreasyonlar yani işlemler tanımlanır.
    //{
    //public void Hesapla() --> normalde bu şekilde olan sınıf birden çok krediyi aynı işlemi uygulatmak için 'interface' olur.    
    //}

    interface IKrediManager //--> başında I kullanmamızın sebebi görünürlüğü arttırmak
    {
        void Hesapla();
        //void birşeyyap();
    }
}       //interface kurallar içerir ve implement(uygulama) olduğu classlar bu kuralları içerir.
        //interfaceleri birbirinin alternatifi olan ama kod durumu farklı olan içerikler için kullanırız.
