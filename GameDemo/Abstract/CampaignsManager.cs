using GameDemo.Entities;
using System;

namespace GameDemo.Abstract
{
    public class CampaignsManager : ICampaignService
    {
        public void Add(Campaigns compaigns)
        {
            Console.WriteLine("Kampanya eklendi.");
        }
        public void Delete(Campaigns entity)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Updade(Campaigns campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }

    }
}
