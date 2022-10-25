using System;
using System.Collections.Generic;
using System.Text;
using GameMarketProject.Abstract;
using GameMarketProject.Entities;
using GameMarketProject.Concrete;

namespace GameMarketProject.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        void CalculateDiscount(Game game, Campaign campaign);
    }
}
