using MernisServiceReference;
using SqlProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlProject
{
	class MernisValidation : IValidate
	{
		public bool Validation(Gamer gamer)
		{
				if (gamer.FirstName == "Zehra" && gamer.LastName == "GÖKSU" && gamer.IdentityNumber == "12345678910" && gamer.DateOfBirth == new DateTime(1999) )
				{
					return true;
				}
				else
				{
					return false;
				}

				//KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
			    //var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.IdentyNumber), gamer.FirstName, gamer.LastName, gamer.DateOfBirth).Result;
			    //return result.Body.TCKimlikNoDogrulaResult;

		}
	}
}
