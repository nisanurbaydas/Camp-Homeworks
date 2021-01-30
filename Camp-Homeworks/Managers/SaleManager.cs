using System;
using System.Collections.Generic;
using System.Text;
using Camp_Homeworks.Interfaces;
using Camp_Homeworks.Entities;

namespace Camp_Homeworks.Managers
{
    class SaleManager : ISaleManager
    {
        List<Sales> salesList = new List<Sales>();

        public void Add(Sales sale)
        {
            salesList.Add(sale);
            Console.WriteLine("Sale has been added");

        }

        public void ListAllSales()
        {
            foreach (Sales sale in salesList)
            {
                Console.WriteLine("***************");
                Console.WriteLine(sale.Id);
                Console.WriteLine(sale.gameId);
                Console.WriteLine(sale.gamerId);
                Console.WriteLine(sale.campaignId);
            }   
        }
    }
}
