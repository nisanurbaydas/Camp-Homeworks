using Camp_Homeworks.Entities;
using Camp_Homeworks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp_Homeworks.Services
{
    class GamerCheckService : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
