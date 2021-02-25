using System;
using System.Collections.Generic;

namespace Object_Oriented_Programming___III
{
    class Program
    {
        static void Main(string[] args)

        
        //interfacelerde o interface implement eden class'ın referans numarasını tutabilir.

        //IKrediManager ihtiyackrediManager = new IhtiyacKrediManager();
        //ihtiyackrediManager.Hesapla();

        //IKrediManager tasitkrediManager = new TasitKrediManager();
        //tasitkrediManager.Hesapla();

        //IKrediManager konutkrediManager = new KonutKrediManager();
        //konutkrediManager.Hesapla();
       
        //---------------------------------------------------------------------------

        //IKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
        //IKrediManager tasitKrediManager = new TasitKrediManager();
        //IKrediManager konutKrediManager = new KonutKrediManager();

        //BasvuruManager basvuruManager = new BasvuruManager();
        //basvuruManager.Basvuru(konutKrediManager);

        //Yukarıdaki komutları çalıştırdığımızda komut kendisini çağırmış olur ve ekranda bize "Konut kredisi ödeme planı hesaplandı." çıktısını verir.

        //---------------------------------------------------------------------------
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService loggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.Basvuru(new EsnafKredisiManager(), new SmsLoggerService());


            List<IKrediManager> krediler = new List<IKrediManager> { ihtiyacKrediManager, tasitKrediManager, konutKrediManager };
            {
                basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            }
            //Bu kodlar ile bu sefer tüm kredileri tek tek sayarak liste halinde yolldaık ve hepsini tek tek hesapladık.
        }
    }
}
