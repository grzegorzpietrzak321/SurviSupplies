﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace SurviSupplies.Controllers
{
    public class ContainerController : Controller
    {
        public ContainerController()
        {
        }

        public string Index()
        {
            return "Wszystkie pojemniki! " + nameof(Index);
        }
    }
}
