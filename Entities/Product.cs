using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrderSummary.Entities.Enums;
using OrderSummary.Entities;

namespace OrderSummary.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
