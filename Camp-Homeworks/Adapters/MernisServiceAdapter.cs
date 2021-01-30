using Camp_Homeworks.Entities;
using Camp_Homeworks.Interfaces;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp_Homeworks.Adapters
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.nationalityId), gamer.firstName, gamer.surName, gamer.birthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
