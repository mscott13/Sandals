using System;
using System.Collections.Generic;
using System.Text;

namespace Sandals.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public decimal RetailPrice { get; set; }

        public string FormattedRetailPrice 
        {
            get 
            {
                return RetailPrice.ToString("C0");
            }
        }
    }
}
