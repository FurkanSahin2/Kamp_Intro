using GameDemo;
using GameDemo.Abstract;
using GameDemo.Entities;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            var gamer = new Gamer { Id = 1, BirthYear = 2002, FirstName = "FURKAN", LastName = "ŞAHİN", NationalityId = 12345678910 };
            gamerManager.Add(gamer);
            var campaign = new Campaigns { Id = 1, Description = "Dev İndirim", Title = "10% İndirim", };
            //SalesManager salesManager = new SalesManager();
            //var sales = new Sales { GamerId = gamer.Id }; 
            //salesManager.Add(sales);
            gamer.PurchaseGame("GTA", 12, 205.5, new List<Campaigns>{ campaign });
            System.Console.WriteLine("Hello World!");

        }
    }
}