using System;
namespace SurviSupplies.Models
{
    public class Item
    {
        public Item()
        {

        }

        //PK
        public int ItemId { get; set; }
        public string Name { get; set; }

        //FK
        public int ProductId { get; set; }
    }
}

