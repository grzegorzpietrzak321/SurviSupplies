using System;
using Microsoft.AspNetCore.Mvc;
using SurviSupplies.Services;
using SurviSupplies.ViewModels;

namespace SurviSupplies.Controllers
{
    public class ItemController : Controller
    {
        private IItemData _itemData;

        public ItemController(IItemData itemData)
        {
            _itemData = itemData;
        }

        public IActionResult Index()
        {
            var model = new ItemIndexViewModel();

            



            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _itemData.Get(id);

            return View(model);
        }
    }
}
