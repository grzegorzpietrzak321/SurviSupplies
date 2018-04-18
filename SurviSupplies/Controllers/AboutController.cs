using System;
using Microsoft.AspNetCore.Mvc;

namespace SurviSupplies.Controllers
{
    public class AboutController : Controller
    {
        public AboutController()
        {
        }

        public string Index()
        {
            return "O aplikacji";
        }
    }
}
