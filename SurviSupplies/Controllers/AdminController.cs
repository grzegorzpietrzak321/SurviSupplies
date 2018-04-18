using System;
using Microsoft.AspNetCore.Mvc;
using SurviSupplies.Controllers;

namespace SurviSupplies.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
