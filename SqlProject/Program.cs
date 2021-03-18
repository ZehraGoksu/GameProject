using SqlProject.Entities;
using SqlProject.Managers;
using System;

namespace SqlProject
{
	class Program
	{
		static void Main(string[] args)
		{
            GamerManager gamerManager = new GamerManager(new MernisValidation());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                DateOfBirth = new DateTime(1999),
                FirstName = "Zehra",
                LastName = "GÖKSU",
                IdentityNumber = "12345678910"
            });

            Game game1= new Game {Id = 1, Name = "GTA", Sale = 260 };

            Game game2 = new Game {Id = 2, Name = "PES 2021", Sale = 134 };

            Campaign campaign1 = new Campaign {CampaignId = 1, CampaignName = "Mart indirimi", Discount = 20 };

            CampaignManager campaignManager1 = new CampaignManager(); 
            campaignManager1.Add(game2, campaign1);

            SaleManager saleManager = new SaleManager();
            saleManager.Add(new Gamer {FirstName = "Zehra" }, game1, campaign1);



        }
	}
}
