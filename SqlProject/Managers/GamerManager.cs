using SqlProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlProject
{
	class GamerManager : IGamerService
	{
        IValidate _userValidate;

        public GamerManager(IValidate userValidateService)
        {
            _userValidate = userValidateService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidate.Validation(gamer) == true)
            {
                Console.WriteLine("Başarıyla kayıt gerçekleştirildi.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız oldu.");
            }

        }
        public void Delete(Gamer gamer)
		{
			Console.WriteLine("Kayıt silindi");
		}

		public void Update(Gamer gamer)
		{
			Console.WriteLine("Kayıt güncellendi");
		}
	}
}
