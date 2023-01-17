using GameDemo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameDemo.Entities
{

    public class Gamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int BirthYear { get; set; }
        
        public long NationalityId { get; set; }

        public List<Sales> SalesList { get; set; }

        public Gamer()
        {
            SalesList = new List<Sales>();
        }

        public Sales PurchaseGame(string productName,int unit, double total,List<Campaigns> campaigns)
        {
            var sales = new Sales { ProductName = productName, Unit = unit, Total = total, Campaigns = campaigns.Select(s => new SalesCampaign { CampaignId = s.Id }).ToList()  };
            SalesList.Add(sales);
            return sales;
        }
    }

}