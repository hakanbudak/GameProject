using Game_Shop.Abstract;
using Game_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Shop.Concrete
{
    public class GamerManager:BaseGamersManager
    {
         private IPersonCheckService _personCheckService;

        public GamerManager()
        {
        }

        public GamerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
               base.Save(customer);
            }
            else
            {
                throw new Exception("Geçerli kişi değil");
            }
           
        }
        
    }
}
