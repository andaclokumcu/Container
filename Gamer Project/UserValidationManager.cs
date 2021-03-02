using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer_Project
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear ==1996 && gamer.FirstName=="Andaç"
                && gamer.LastName == "Lokumcu" && gamer.IdentityNumber == 1234)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
