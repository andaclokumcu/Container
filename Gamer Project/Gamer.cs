using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer_Project
{
    class Gamer
    {
        //Bir oyun yazmak istiyorsunuz.Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz. Yeni üye, satış ve kampanya yönetimi yapılması isteniyor. 

        //Gereksinimler

        //1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz.
        //Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. 
        //(E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır.Bunu yapacak servisi simule etmeniz yeterlidir.)

        //2.Oyun satışı yapılabilecek satış ortamını simule ediniz.
        //(Yapılan satışlar oyuncu ile ilişkilendirilmelidir.Oyuncunun parametre olarak metotta olmasını kastediyorum.)

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }
    }
}
