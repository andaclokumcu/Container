using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming___III
{
    class BasvuruManager
   
    //public void Basvuru()
    
    //KonutKrediManager konutKrediManager = new KonutKrediManager();
    //konutKrediManager.Hesapla();

    //Yukarıdaki şekilde kullanamayız çünkü böyle yaparsaktüm başvuruları konut kredisine bağımlı hale getirmiş oluruz.
    //--------------------------------------------------------

    //public void Basvuru(IKrediManager krediManager)

    //Yukarıdaki şekilde kullanım 'bize hangi konutu kullanacağımızı söyle' bilgisi verir ve doğru kullanımdır.Komuta göre hangi kredinin referansının numarasının çalışacağını belirler.

    {
        public void Basvuru(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
 }

