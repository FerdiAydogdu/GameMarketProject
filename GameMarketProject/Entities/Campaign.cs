using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarketProject.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }
    }
}
