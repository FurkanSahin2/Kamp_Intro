using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class SalesCampaign
    {
        public int SalesId { get; set; }
        public int CampaignId { get; set; }

        public Sales Sales { get; set; }
        public Campaigns Campaign { get; set; }
    }
}
