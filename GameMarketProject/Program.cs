using System;
using GameMarketProject.Abstract;
using GameMarketProject.Entities;
using GameMarketProject.Concrete;
using GameMarketProject.Adapters;

namespace GameMarketProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer()
            {
                Id = 1,
                DateOfBirth = new DateTime(2000, 6, 4),
                FirstName = "Ferdi",
                LastName = "Aydoğdu",
                NationalityId = "12345678900"
            };

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer);

        }
    }
}
