﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrderSummary.Entities.Enums;
using OrderSummary.Entities;
using System.Globalization;

namespace OrderSummary.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {
        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double SubTotal()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Substotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
