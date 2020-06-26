using Sandals.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sandals.Service
{
    public class DataService
    {
        public List<OrderHistory> GetOrderHistory() 
        {
            return new List<OrderHistory>()
            {
                new OrderHistory()
                {
                    OrderHistoryId = 0,
                    Description = "Type1 Sandals Small",
                    RetailPrice = 1250.50f,
                    Quantity = 1,
                    OrderDate = DateTime.Now,
                    OrderStatus = OrderHistory.STATUS_PROCESSING,
                    ImageUrl = "https://via.placeholder.com/300x300.png?text=placeholder.png"
                },
                new OrderHistory()
                {
                    OrderHistoryId = 1,
                    Description = "Type3 Sandals Large",
                    RetailPrice = 5000.25f,
                    Quantity = 1,
                    OrderDate = DateTime.Now,
                    OrderStatus = OrderHistory.STATUS_PROCESSING,
                    ImageUrl = "https://via.placeholder.com/300x300.png?text=placeholder.png"
                }
            };
        }
        public OrderHistoryDetail GetOrderHistoryDetail(int orderHistoryId) 
        {
            return new OrderHistoryDetail()
            {
                ImageSource = new List<string> { "img_placeholder.jpg", "img_placeholder.jpg", "img_placeholder.jpg" },
                OrderItems = new List<OrderItem>()
                {
                    new OrderItem() 
                    {
                        ImageUrl = "img_placeholder.jpg",
                        Description = "Type1 Sandals Small",
                        RetailPrice = 3200,
                        Quantity = 1
                    }
                }
            };
        }
        public List<Product> GetProducts() 
        {
            return new List<Product>()
            {
                new Product()
                {
                    ProductId = 1,
                    Title = "Type1 Sandals Large",
                    RetailPrice = 2000,
                    ImageUrl = "shoe_placeholder.png"
                },
                new Product()
                {
                    ProductId = 2,
                    Title = "Type2 Sandals Medium",
                    RetailPrice = 1200,
                    ImageUrl = "shoe_placeholder.png"
                },
                new Product()
                {
                    ProductId = 2,
                    Title = "Type2 Sandals Small",
                    RetailPrice = 800,
                    ImageUrl = "shoe_placeholder.png"
                }
            };
        }

    }
}
