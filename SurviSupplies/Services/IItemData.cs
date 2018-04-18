using System;
using SurviSupplies.Models;
using System.Collections.Generic;

namespace SurviSupplies.Services
{
    public interface IItemData
    {
        IEnumerable<Item> GetAll();

        Item Get(int id);

        Item Add();

        Item Delete();
    }
}
