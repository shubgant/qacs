using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("Products")]
        public IEnumerable<Product> Products() {
            List<Product> products = [];
            products.Add(new Product { ProductId = 1, Name = "Rolos" });
            products.Add(new Product { ProductId = 2, Name = "Bag of Crisps" });
            products.Add(new Product { ProductId = 3, Name = "Apple" });
            products.Add(new Product { ProductId = 4, Name = "Cheese Sandwich" });
            return products;
        }

        [HttpGet("OrderedProducts")]
        public IEnumerable<Product> OrderedProducts()
        {
            List<Product> products = [];
            products.Add(new Product { ProductId = 1, Name = "Rolos" });
            products.Add(new Product { ProductId = 2, Name = "Bag of Crisps" });
            products.Add(new Product { ProductId = 3, Name = "Apple" });
            products.Add(new Product { ProductId = 4, Name = "Cheese Sandwich" });
            return products.OrderBy(p => p.Name).ToList();
        }

        [HttpGet("Products/{id:int}")]
        public Product Products(int id)
        {
            Product p = new Product { ProductId = id, Name = "Rolos" };
            return p;
        }

        [HttpGet("Products/{name}")]
        public Product Products(string name)
        {
            Product p = new Product { ProductId = 1, Name = name };
            return p;
        }
    }
}
