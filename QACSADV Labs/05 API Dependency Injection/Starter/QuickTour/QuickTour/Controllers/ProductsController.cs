//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;
using QuickTour.Models;

namespace QuickTour.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        IProductsContext _context;
        public ProductsController(IProductsContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        [HttpGet("Products")]
        [HttpGet("ProductDetails")]
        public IEnumerable<Product> ProductsDetail()
        {
            return _context.GetProducts();
        }

        [HttpGet("ProductDetail/{id:int}")]
        [HttpGet("Products/{id:int}")]
        [HttpGet("{id:int}")]
        public Product? ProductsDetail(int id)
        {
            Product? p = _context.GetProducts().FirstOrDefault(p => p.ProductId == id);
            return p;
        }

        [HttpGet("ProductDetail/{id:int}/{name}")]
        [HttpGet("Products/{id:int}/{name}")]
        [HttpGet("{id:int}/{name}")]
        public Product? ProductsDetail(int id, string? name)
        {
            Product? p = _context.GetProducts().FirstOrDefault(p => p.ProductId == id && p.Name == name);
            return p;
        }

        [HttpGet("ProductDetail/{name}")]
        [HttpGet("Products/{name}")]
        [HttpGet("{name}")]
        public Product? ProductsDetail(string? name)
        {
            Product? p = _context.GetProducts().FirstOrDefault(p => p.Name == name);
            return p;
        }

        [HttpGet("Ordered")]
        public IEnumerable<Product> OrderedProducts()
        {
            return _context.GetProducts().OrderBy(p => p.Name).ToList();
        }
    }
}
