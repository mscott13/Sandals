using System;
using System.Collections.Generic;
using System.Text;

namespace Sandals.Models
{
    public class OrderHistory
    {
        public static string STATUS_PROCESSED = "PROCESSED";
        public static string STATUS_NOT_PROCESSED = "NOT PROCESSED";
        public static string STATUS_PROCESSING = "PROCESSING";

        public int OrderHistoryId { get; set; }
        public string Description { get; set; }
        public float RetailPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string ImageUrl { get; set; }
    }
}
