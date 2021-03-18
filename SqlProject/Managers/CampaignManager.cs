using SqlProject.Abstract;
using SqlProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlProject.Managers
{
	class CampaignManager : ICampaign
	{
		public void Add(Game game, Campaign campaign)
		{
			Console.WriteLine(game.Name + " oyununa " + campaign.Discount + " tl indirim tanımlandı.");
		}

		public void Delete(Game game, Campaign campaign)
		{
			Console.WriteLine(game.Name + " oyununun " + campaign.Discount + " tl indirimi silindi.");
		}

		public void Update(Game game, Campaign campaign)
		{
			Console.WriteLine(game.Name + " oyununun " + campaign.Discount + " tl olarak indirimi güncelledi");
		}
	}
}
