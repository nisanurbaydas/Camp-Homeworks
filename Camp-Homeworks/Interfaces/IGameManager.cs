using System;
using System.Collections.Generic;
using System.Text;
using Camp_Homeworks.Entities;
using Camp_Homeworks.Managers;

namespace Camp_Homeworks.Interfaces
{
    interface IGameManager
    {
        public void Add(Game game);
        public void Delete(Game game);
        public Game GetGame(int id);
        public void ListAllGames();
    }
}
