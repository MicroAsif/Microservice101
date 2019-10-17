using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.API.Service
{
    public class OrderService
    {
        public static IEnumerable<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order {Id = 301, CustomerId = 1, Orders = new List<OrderItem> { 
                    new OrderItem {Id = 401, ProductId = 101}, 
                    new OrderItem {Id = 402, ProductId = 102}
                }},
                new Order {Id = 302, CustomerId = 2, Orders = new List<OrderItem> {
                    new OrderItem {Id = 403, ProductId = 102},
                    new OrderItem {Id = 404, ProductId = 103}
                }},
                 new Order {Id = 303, CustomerId = 3, Orders = new List<OrderItem> {
                    new OrderItem {Id = 405, ProductId = 101},
                    new OrderItem {Id = 406, ProductId = 103}
                }},
            };
        }
        public static Order GetOrder(int orderId)
        {
            return GetOrders().FirstOrDefault(x => x.Id == orderId);
        }
    }
    public class Order
    {
        public Order()
        {
            Orders = new List<OrderItem>();
        }
                
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public double Total { get; private set; }

        public List<OrderItem> Orders { get; set; }
    }
    public class OrderItem
    {
        public OrderItem()
        {
             
        }
        public int Id { get; set; }
        public int ProductId { get; set; }
        
    }

}
