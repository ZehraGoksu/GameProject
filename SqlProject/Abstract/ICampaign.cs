using SqlProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlProject.Abstract
{
	interface ICampaign
	{
		void Add(Game game, Campaign campaign);

		void Update(Game game, Campaign campaign);

		void Delete(Game game, Campaign campaign);
	}
}
