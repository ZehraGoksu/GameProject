using SqlProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlProject
{
	class GameManager : IGameService
	{
		public void Add(Game game)
		{
			Console.WriteLine(game.Name + " " + "oyunu başarılı bir şekilde eklendi.");
		}

		public void Delete(Game game)
		{
			Console.WriteLine(game.Name + " " + "oyunu başarılı bir şekilde güncellendi.");
		}

		public void Update(Game game)
		{
			Console.WriteLine(game.Name + " " + "oyunu başarılı bir şekilde silindi.");
		}
	}
}
