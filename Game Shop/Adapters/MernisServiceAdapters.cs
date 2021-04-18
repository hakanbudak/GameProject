using Game_Shop.Abstract;
using Game_Shop.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Shop.Adapters
{
    public class MernisServiceAdapters:IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationaltyId, customer.FirstName = "Hakan".ToUpper(), customer.LastName = "Budak".ToUpper(), DateTime = (2000, 4, 10));
        }

       
    }
}
