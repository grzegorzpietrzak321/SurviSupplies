using System;
namespace SurviSupplies.Models
{
    public class Product
    {
        public Product()
        {
        }

        public int ProductId { get; set; }
        public long EAN { get; set; }
        public string Memo { get; set; }
    }
}
