using System;
using System.Collections.Generic;
using System.Text;
using GameMarketProject.Abstract;
using GameMarketProject.Entities;
using GameMarketProject.Concrete;

namespace GameMarketProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " added!");
        }

        public void CalculateDiscount(Game game, Campaign campaign)
        {
            double newPrice = game.UnitPrice - ((game.UnitPrice * campaign.DiscountRate) / 100);
            Console.WriteLine("New Price: " + newPrice);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " deleted!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " updated!");
        }
    }
}
