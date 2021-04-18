using Game_Shop.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Shop.Entities
{
    public class Customer : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationaltyId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
