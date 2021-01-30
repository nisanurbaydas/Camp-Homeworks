using Camp_Homeworks.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Camp_Homeworks.Entities;
using Camp_Homeworks.Interfaces;
using Camp_Homeworks.Managers;
using Camp_Homeworks.Services;

namespace Camp_Homeworks.Managers
{
    class GamerManager : IGamerManager
    {
        GamerCheckService gamerCheckService = new GamerCheckService();
        List<Gamer> gamers = new List<Gamer>();
        public void Add(Gamer gamer)
        {
            
            if (gamerCheckService.CheckIfRealPerson(gamer))
            {
                gamers.Add(gamer);
                Console.WriteLine(gamer.firstName + " " + gamer.surName + " added.");
            }
            else
            {
                throw new Exception("Not valid.");
            }
        }

        public void Delete(Gamer gamer)
        {
            gamers.Remove(gamer);
            Console.WriteLine("Gamer has been deleted.");
        }

        public Gamer GetGamer(int id)
        {
            Gamer _gamer = new Gamer();
            foreach (Gamer gamer in gamers)
            {
                if (gamer.id == id)
                {
                    _gamer = gamer;
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("First Name: " + gamer.firstName);
                    Console.WriteLine("Last Name: " + gamer.surName);
                    Console.WriteLine("Birth Year: " + gamer.birthYear);
                    Console.WriteLine("TC Number: " + gamer.nationalityId);
                }
            }
            return _gamer;
        }

        public void listGamers()
        {
            foreach (Gamer gamer in gamers)
            {
                Console.WriteLine("***********");
                Console.WriteLine("ID: " + gamer.id);
                Console.WriteLine("First Name: " + gamer.firstName);
                Console.WriteLine("Surname: " + gamer.surName);
                Console.WriteLine("Birth date: " + gamer.birthYear);
                Console.WriteLine("Nationality ID: " + gamer.nationalityId);
            }
        }

        public void Update(Gamer oldGamer, Gamer newGamer)
        { 
            if (gamerCheckService.CheckIfRealPerson(newGamer))
            {
                gamers.Remove(oldGamer);
                gamers.Add(newGamer);
                Console.WriteLine(newGamer.firstName + " " + newGamer.surName + " updated.");
            }
            else
            {
                throw new Exception("Not valid.");
            }
        }
    }
}
