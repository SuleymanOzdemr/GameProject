using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    class SalesManager:ISalesService
    {
        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + ", " + game.GameName + " oyununu " + game.GamePrice + " TL'ye satın aldı.");
        }

        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            double total = game.GamePrice - ((game.GamePrice * campaign.DiscountRate) / 100.0);
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + ", " + game.GameName + " oyununu " + campaign.CampaignName + " kampanyası ile %" + campaign.DiscountRate + " indirimle " + total + " TL'ye satın aldı.");
        }
    }
}
