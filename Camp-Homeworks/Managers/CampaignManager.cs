using Camp_Homeworks.Entities;
using Camp_Homeworks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp_Homeworks.Managers
{
    class CampaignManager : ICampaignManager
    {
       
        List<Campaign> campaigns = new List<Campaign>();

        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine("Campaign has been added.");

        }

        public void Delete(Campaign campaign)
        {
            campaigns.Remove(campaign);
            Console.WriteLine("Campaign has been removed.");
        }

        public Campaign getCampaign(int id)
        {
            Campaign _campaign = new Campaign();
            foreach (Campaign campaign in campaigns)
            {
                if (campaign.Id == id)
                {
                    _campaign = campaign;
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Id: " + campaign.Id);
                    Console.WriteLine("Name: " + campaign.name);
                    Console.WriteLine("Discount rate: " + campaign.discountRate);
                }
            }
            return _campaign;
        }

        public void ListAll()
        {
            foreach (Campaign campaign in campaigns)
            {
                Console.WriteLine("****************");
                Console.WriteLine("Campaign Name: " + campaign.name);
                Console.WriteLine("Campaign Rate: " + campaign.discountRate);
            }
        }

        public void Update(Campaign oldCampaign, Campaign newCampaign)
        {
            campaigns.Remove(oldCampaign);
            campaigns.Add(newCampaign);
            Console.WriteLine("The campaign has been updated.");
        }
    }
}
