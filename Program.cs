using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Adapter;
using GameProject.Concrete;
using GameProject.Entity;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            GamerManager gamerManager = new GamerManager( new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                DateofBirth = new DateTime(1998, 8, 46),
                FirstName = "Süleyman",
                LastName = "Özdemir",
                Id = 5656565776
            });
            */

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Ad";
            gamer1.LastName = "Soyad";
            gamer1.IdentityNumber = "10123456789";
            gamer1.DateofBirth = new DateTime(2021, 01, 01);

            Gamer gamer2 = new Gamer();
            gamer2.Id = 1;
            gamer2.FirstName = "Oyuncu1";
            gamer2.LastName = "Oyuncu1";
            gamer2.IdentityNumber = "12345678901";
            gamer2.DateofBirth = new DateTime(2021, 01, 01);
            //Oyuncu oluşturma sonu

            //Oyuncu ekleme
            //E-Devlet sistemlerini kullanarak doğrulama yapma
            //gamer1 oyuncusunun bilgileri doğru girilmedir
            GamerManager gamerManager1 = new GamerManager(new MernisServiceAdapter());
            gamerManager1.Add(gamer1);

            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            gamerManager2.Add(gamer2);
            //Oyuncu ekleme sonu

            //Oyun oluşturma
            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Oyun1";
            game1.GamePrice = 150;

            Game game2 = new Game();
            game2.GameId = 1;
            game2.GameName = "Oyun2";
            game2.GamePrice = 220;
            //Oyun oluşturma sonu

            //Oyun ekleme
            GameManager gameManager1 = new GameManager();
            gameManager1.Add(game1);
            gameManager1.Add(game2);
            //Oyun ekleme sonu

            //Kampanya ekleme
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Kampanya1";
            campaign1.DiscountRate = 10;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 2;
            campaign2.CampaignName = "Kampanya2";
            campaign2.DiscountRate = 20;

            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(campaign1);
            campaignManager1.Add(campaign2);
            //Kampanya ekleme sonu

            //Satış
            Console.WriteLine("------------------------");
            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game1, gamer1);
            salesManager.Sales(game2, gamer1);
            salesManager.CampaignSales(game1, gamer1, campaign1);
            salesManager.CampaignSales(game2, gamer1, campaign2);
            //Satış sonu
            Console.WriteLine("------------------------");

            //Oyuncu güncelleme/silme
            gamerManager1.Update(gamer1);
            //gamerManager1.Update(gamer2);
            gamerManager1.Delete(gamer1);
            //gamerManager1.Delete(gamer2);
            //Oyuncu güncelleme/silme sonu

            //Oyun güncelleme/silme
            gameManager1.Update(game1);
            gameManager1.Update(game2);
            gameManager1.Delete(game1);
            gameManager1.Delete(game2);
            //Oyun güncelleme/silme sonu

            //Kampanya güncelleme/silme
            campaignManager1.Update(campaign1);
            campaignManager1.Update(campaign2);
            Console.ReadLine();
        }
    }
}
