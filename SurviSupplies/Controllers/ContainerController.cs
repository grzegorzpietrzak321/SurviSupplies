using System;
namespace SurviSupplies.Controllers
{
    public class ContainerController
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
