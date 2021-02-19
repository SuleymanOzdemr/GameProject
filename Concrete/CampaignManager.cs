using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entity;

namespace GameProject
{
    class CampaignManager:ICampainService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " silindi");
        }

        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Eklendi");
        }

       

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Guncellendi");
        }
    }
}
