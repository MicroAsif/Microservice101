using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.API.FakeService;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet("GetCustomers")]
        public IActionResult GetCustomers()
        {
            return Ok(CustomerService.GetAllCustomers());
        }
        [HttpGet("GetCustomer")]
        public IActionResult GetCustomer(int customerId)
        {
            return Ok(CustomerService.GetCustomer(customerId));
        }

    }
}