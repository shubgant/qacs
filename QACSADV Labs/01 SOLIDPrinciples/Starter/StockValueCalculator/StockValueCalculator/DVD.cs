using System.Diagnostics;

namespace StockValueCalculator
{
    public class DVD : IProduct
    {
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public string Director { get; set; }
        public int Runtime { get; set; }

        public DVD(string name, string director, int runtime, decimal basePrice)
        {
            this.BasePrice = basePrice;
            this.Name = name;
            this.Director = director;
            this.Runtime = runtime;
        }

        public decimal PriceIncludingVAT
        {
            get
            {
                return decimal.Round(BasePrice * 1.20m, 2);
            }
        }

    }

}
