using Game_Shop.Abstract;
using Game_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Shop.Concrete
{
    public class GamerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
