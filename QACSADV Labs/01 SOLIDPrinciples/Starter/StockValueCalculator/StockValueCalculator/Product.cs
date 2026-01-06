using System.Diagnostics;

namespace StockValueCalculator
{
    public interface IProduct
    {
        public string Name { get; set; }    
        public decimal BasePrice { get; set; }
        public decimal PriceIncludingVAT { get; }
   
    }
}
