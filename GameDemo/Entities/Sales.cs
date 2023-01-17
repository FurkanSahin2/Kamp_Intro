using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Sales
    {
        public int Id { get; set; }

        public int GamerId { get; set; }
        public string ProductName { get; set; }
        public int Unit { get; set; }
        public double Total { get; set; }

        public List<SalesCampaign> Campaigns { get; set; }

        public Gamer Gamer { get; set; }
    }
}
