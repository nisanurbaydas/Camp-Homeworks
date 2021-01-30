using System;
using System.Collections.Generic;
using System.Text;
using Camp_Homeworks.Entities;

namespace Camp_Homeworks.Interfaces
{
    interface ICampaignManager
    {
        void Add(Campaign campaign);
        void Update(Campaign oldCampaign, Campaign newCampaign);
        void Delete(Campaign campaign);
        Campaign getCampaign(int id);
        void ListAll();
    }
}
