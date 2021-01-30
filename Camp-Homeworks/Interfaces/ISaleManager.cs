using System;
using System.Collections.Generic;
using System.Text;
using Camp_Homeworks.Entities;

namespace Camp_Homeworks.Interfaces
{
    interface ISaleManager
    {
        void Add(Sales sale);
        void ListAllSales();
    }
}
