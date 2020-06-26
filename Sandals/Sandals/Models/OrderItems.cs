using System;
using System.Collections.Generic;
using System.Text;

namespace Sandals.Models
{
    public class OrderItem
    {
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public double RetailPrice { get; set; }
        public int Quantity { get; set; }
    }
}
