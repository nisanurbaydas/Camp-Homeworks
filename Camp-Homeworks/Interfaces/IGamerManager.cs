using Camp_Homeworks.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp_Homeworks.Interfaces
{
    interface IGamerManager
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        Gamer GetGamer(int id);
        void Update(Gamer oldGamer, Gamer newGamer);
        void listGamers();

    }
}
