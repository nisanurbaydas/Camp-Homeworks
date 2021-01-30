using System;
using System.Collections.Generic;
using System.Text;
using Camp_Homeworks.Entities;
using Camp_Homeworks.Interfaces;
namespace Camp_Homeworks.Managers
{
    class GameManager : IGameManager
    {
        List<Game> games = new List<Game>();

        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine("Game has been added");
        }

        public void Delete(Game game)
        {
            games.Remove(game);
            Console.WriteLine("Game has been deleted");
        }

        public Game GetGame(int id)
        {
            Game _game = new Game();
            foreach (var game in games)
            {
                if (game.id == id)
                {
                    _game = game;
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Id: " + game.id);
                    Console.WriteLine("Game: " + game.name);
                    Console.WriteLine("Price: " + game.price);
                    Console.WriteLine("Stock: " + game.stock);
                }
            }
            return _game;
        }

        public void ListAllGames()
        {
            foreach (Game game in games)
            {
                Console.WriteLine("*******************");
                Console.WriteLine(game.name);
                Console.WriteLine(game.price);
                Console.WriteLine(game.stock);
            }
        }
    }
}
