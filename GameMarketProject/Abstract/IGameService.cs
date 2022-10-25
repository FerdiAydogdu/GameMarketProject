using System;
using System.Collections.Generic;
using System.Text;
using GameMarketProject.Abstract;
using GameMarketProject.Entities;
using GameMarketProject.Concrete;

namespace GameMarketProject.Abstract
{
    interface IGameService
    {
        void Sell(Gamer gamer, Game game);
    }
}
