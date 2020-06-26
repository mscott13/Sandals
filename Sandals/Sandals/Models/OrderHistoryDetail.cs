using System;
using System.Collections.Generic;
using System.Text;

namespace Sandals.Models
{
    public class OrderHistoryDetail
    {
        public List<string> ImageSource { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
