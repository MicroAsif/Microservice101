using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.API.Service
{
    public static class CustomerService
    {
        public static IEnumerable<Customer> GetAllCustomers()
        {
            return new List<Customer> 
            { 
                new Customer {Id = 1, Name = "Asif", Email = "asif0531@live.com", Address = "Dhaka, Bangladesh", Phone = "01723590212"},
                new Customer {Id = 2, Name = "John", Email = "John@live.com", Address = "Toronto, Canada", Phone = "+99 666899"},
                new Customer {Id = 3, Name = "Panday", Email = "panday@live.com", Address = "Rajshahi, Bangladesh", Phone = "01723590212"},
                new Customer {Id = 4, Name = "Hann", Email = "Hann@live.com", Address = "Khulna, Bangladesh", Phone = "01644458888"},
                new Customer {Id = 5, Name = "Doe", Email = "Doe@live.com", Address = "CA, USA", Phone = "555 555 555"},
            };
        }
        public static Customer GetCustomer(int customerId)
        {
            return GetAllCustomers().FirstOrDefault(x => x.Id == customerId);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
