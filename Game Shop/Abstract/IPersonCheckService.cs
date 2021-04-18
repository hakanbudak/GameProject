using Game_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Shop.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
