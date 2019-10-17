using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orders.API.Service;

namespace Orders.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet("GetOrders")]
        public IActionResult GetOrders()
        {
            return Ok(OrderService.GetOrders());
        }
        [HttpGet("GetOrder")]
        public IActionResult GetOrder(int orderId)
        {
            return Ok(OrderService.GetOrder(orderId));
        }
    }
}