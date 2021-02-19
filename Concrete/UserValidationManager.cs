using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {





        /*
         public bool Validate(Gamer gamer)
        {
            if (gamer.BirtYear == 1998 && gamer.FirstName == "Suleyman" && gamer.LastName == "Oz" && gamer.IdentityNumber == 123123 && gamer.Id == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
