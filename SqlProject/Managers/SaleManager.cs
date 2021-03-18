using SqlProject.Abstract;
using SqlProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlProject
{
	class SaleManager : ISaleService
	{
		public void Add(Gamer gamer, Game game, Campaign campaign)
		{

			Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncu " + game.Name + " oyununu " + campaign.Discount + " tl indirimiyle satın aldı.");
		}

		public void Delete(Gamer gamer, Game game)
		{
			Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncu " + game.Name + " oyununu sildi.");
		}

		public void Update(Gamer gamer, Game game)
		{
			Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " adlı oyuncu " + game.Name + " oyunu güncelledi.");
		}
	}
}
