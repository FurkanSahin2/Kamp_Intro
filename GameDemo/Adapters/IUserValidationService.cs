using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IUserValidationService
    {
        bool Validation(Gamer gamer);
    }
}