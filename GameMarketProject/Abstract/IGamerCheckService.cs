using System;
using System.Collections.Generic;
using System.Text;
using GameMarketProject.Entities;

namespace GameMarketProject.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
