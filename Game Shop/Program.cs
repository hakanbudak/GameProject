using Game_Shop.Abstract;
using Game_Shop.Concrete;
using Game_Shop.Entities;
using System;

namespace Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamersManager baseGamersManager = new GamerManager();
            baseGamersManager.Save(new Customer { FirstName = "Hakan".ToUpper(), LastName = "Budak".ToUpper(),NationaltyId="13649188886",DateOfBirth=new DateTime(2000,4,10) });

            Console.Read();
        }
    }
}
