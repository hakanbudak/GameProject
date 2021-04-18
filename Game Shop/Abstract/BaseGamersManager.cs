using Game_Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Shop.Abstract
{
    public abstract class BaseGamersManager : ICustomerService
    {
        public  void Delete(Customer customer)
        {
            Console.WriteLine("Delete to Player db: "+customer.FirstName);
        }

        public virtual
            void Save(Customer customer)
        {
            Console.WriteLine("Saved to Player db: "+customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Update to Player db: "+customer.FirstName);
        }
    }
}
