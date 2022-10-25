using System;
using System.Collections.Generic;
using System.Text;
using GameMarketProject.Abstract;
using GameMarketProject.Entities;
using GameMarketProject.Concrete;

namespace GameMarketProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Sell(Gamer gamer, Game game)
        {
            Console.WriteLine("Game: " + game.GameName + " is sold to: " + gamer.FirstName + " with a price of: " + game.UnitPrice);
        }
    }
}
