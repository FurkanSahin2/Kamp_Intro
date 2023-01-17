using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }



        // İlk ve daha doğru olan yol, yukarıda yaptığımız gibi bunu constructer'a çekmektir.


        public void Add(Gamer gamer) /*, IUserValidationService userValidationService */
        {
            if (_userValidationService.Validation(gamer) == true)

            // if (userValidationService.Validation(gamer) == true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama sağlanamadı. Kayıt başarısız.");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Updade(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}