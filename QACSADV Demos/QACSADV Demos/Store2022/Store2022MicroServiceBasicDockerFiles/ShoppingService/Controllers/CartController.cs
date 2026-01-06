using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingService.Controllers
{
    [Route("api/[controller]")]
    public class CartController : Controller
    {
        // GET: api/cart
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/cart/5
        [HttpGet("{id}")]
        public ActionResult<Cart> Get(int id)
        {
            var cart = new Cart()
            {
                Id = id,
                Items = new List<Product>()
                {
                    new Product()
                    {
                        Id = 33,
                        Description = "",
                        Sku = "abc123",
                        Name = "Laptop",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 82
                    },
                    new Product()
                    {
                        Id = 14,
                        Description = "",
                        Sku = "xyz1238",
                        Name = "iPhone",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 67
                    },
                    new Product()
                    {
                        Id = 20,
                        Description = "",
                        Sku = "xyz1239",
                        Name = "Jacket",
                        DiscountPrice = 20.99m,
                        RegularPrice = 29.99m,
                        Quantity = 405
                    }
                }
            };

            return cart;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
