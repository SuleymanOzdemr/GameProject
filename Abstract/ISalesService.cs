using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entity;

namespace GameProject.Abstract
{
    interface ISalesService
    {
        void Sales(Game game, Gamer gamer);
        void CampaignSales(Game game, Gamer gamer, Campaign campaign);

    }
}
