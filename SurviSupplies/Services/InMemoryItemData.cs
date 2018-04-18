using System;
using System.Collections.Generic;
using SurviSupplies.Models;
using System.Linq;

namespace SurviSupplies.Services
{
    public class InMemoryItemData : IItemData
    {
        private List<Item> _items;

        public InMemoryItemData()
        {
            _items = new List<Item>
            {
                new Item { ItemId = 1, Name = "Zapałki", ProductId = 1},
                new Item { ItemId = 2, Name = "Zapalniczka", ProductId = 2},
                new Item { ItemId = 3, Name = "Krzesiwo", ProductId = 3},
                new Item { ItemId = 4, Name = "Podpałka", ProductId = 4}
            };
        }

        public Item Add()
        {
            throw new NotImplementedException();
        }

        public Item Delete()
        {
            throw new NotImplementedException();
        }

        public Item Get(int id)
        {
            return _items.FirstOrDefault(r => r.ItemId == id);
        }

        public IEnumerable<Item> GetAll()
        {
            return _items.OrderBy(r => r.ItemId);
        }
    }
}
