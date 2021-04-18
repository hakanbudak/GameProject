using Game_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Shop.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }
}
