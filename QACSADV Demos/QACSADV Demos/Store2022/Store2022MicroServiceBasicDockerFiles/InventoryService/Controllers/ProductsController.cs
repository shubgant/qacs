using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InventoryService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryService.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var products = new List<Product>(){
                new Product()
                {
                    Id = 1,
                    Description = "",
                    Sku = "abc12300",
                    Name = "Toy1",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 2,
                    Description = "",
                    Sku = "xyz123",
                    Name = "Toy2",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 3,
                    Description = "",
                    Sku = "abc12300",
                    Name = "Toy3",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 4,
                    Description = "",
                    Sku = "xyz123",
                    Name = "Toy4",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 5,
                    Description = "",
                    Sku = "abc12300",
                    Name = "Toy5",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 6,
                    Description = "",
                    Sku = "xyz123",
                    Name = "Toy6",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 7,
                    Description = "",
                    Sku = "abc12300",
                    Name = "Toy7",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                },
                new Product()
                {
                    Id = 8,
                    Description = "",
                    Sku = "xyz123",
                    Name = "Toy8",
                    DiscountPrice = 20.99m,
                    RegularPrice = 29.99m,
                    Quantity = 100
                }
            };

            return products;
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/products
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/products/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
