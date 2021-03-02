using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer_Project
{
    interface IUserValidationService
    {
//Sistemi yani girdileri doğrulama mantığı
        
        bool Validate(Gamer gamer);

    }
}
