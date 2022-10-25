using System;
using System.Collections.Generic;
using System.Text;
using GameMarketProject.Abstract;
using GameMarketProject.Entities;
using GameMarketProject.Concrete;

namespace GameMarketProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " added!");
            }
            else
            {
                throw new Exception("Not a valid!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " deleted!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " updated!");
        }
    }
}
