using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.API.Service;

namespace Products.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            return Ok(ProductService.GetProducts());
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int productId)
        {
            return Ok(ProductService.GetProduct(productId));
        }
    }
}