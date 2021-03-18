using SqlProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlProject.Abstract
{
	interface ISaleService
	{
		void Add(Gamer gamer, Game game, Campaign campaign);
		void Update(Gamer gamer, Game game);
		void Delete(Gamer gamer, Game game);

	}
}
