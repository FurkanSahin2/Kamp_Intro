using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Campaigns
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<SalesCampaign> Sales { get; set; }
    }
}
