using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.BirthYear == 2002 && gamer.FirstName == "FURKAN" && gamer.LastName == "ŞAHİN" && gamer.NationalityId == 12345678910)
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