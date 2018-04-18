using System;
using System.Collections.Generic;
using SurviSupplies.Models;

namespace SurviSupplies.ViewModels
{
    public class ItemIndexViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public IEnumerable<Container> Containers { get; set; }

        IEnumerable<Item> _items;
        IEnumerable<Container> _container;

        public ItemIndexViewModel(IEnumerable<Container> containers, IEnumerable<Item> items)
        {
            _items = items;
            _container = containers;
        }

        public ItemIndexViewModel()
        {
            
        }


    }
}