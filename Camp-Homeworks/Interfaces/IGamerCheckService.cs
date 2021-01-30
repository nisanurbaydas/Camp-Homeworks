using System;
using System.Collections.Generic;
using System.Text;
using Camp_Homeworks.Entities;

namespace Camp_Homeworks.Interfaces
{
    interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
