using System.Diagnostics;

namespace StockValueCalculator
{
    public class Book : IProduct
    {
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book(string name, string author, int pages, decimal basePrice)
        {
            this.BasePrice = basePrice;
            this.Name = name;
            this.Author = author;
            this.Pages = pages;
        }

        public decimal PriceIncludingVAT
        {
            get
            {
                return this.BasePrice;
            }
        }

    }

}
