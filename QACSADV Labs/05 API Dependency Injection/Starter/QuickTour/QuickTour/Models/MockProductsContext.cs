namespace QuickTour.Models
{
    public class MockProductsContext : IProductsContext
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>() {
                new Product { ProductId = 1, Name = "Rolos" },
                new Product { ProductId = 2, Name = "Bag of Crisps" },
                new Product { ProductId = 3, Name = "Apple" },
                new Product { ProductId = 4, Name = "Cheese Sandwich" },
                new Product { ProductId = 5, Name = "Can of Coke" }
            };
        }
    }
}
