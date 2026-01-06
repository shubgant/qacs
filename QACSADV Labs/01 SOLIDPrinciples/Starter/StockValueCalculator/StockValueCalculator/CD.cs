using System.Diagnostics;

namespace StockValueCalculator
{
    public class CD : IProduct
    {
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public string Artist { get; set; }
        public int Tracks { get; set; }

        public CD(string name, string artist, int tracks, decimal basePrice)
        {
            this.BasePrice = basePrice;
            this.Name = name;
            this.Artist = artist;
            this.Tracks = tracks;
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
