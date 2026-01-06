using System;
using System.Collections.Generic;
using System.Net;

// -------------------------------------------------------------------------
// if using .Net Core
// https://docs.microsoft.com/en-us/dotnet/api/system.text.json?view=net-5.0
using System.Text.Json;
using Newtonsoft.Json;

namespace StockTicker
{
    internal class Program
    {
        private static readonly IStockTickerService stockTickerService = new StockTickerService();
        public static async Task Main(string[] args)
        {
            try
            {
                string symbol = "tesco"; // stock symbol
                Console.WriteLine($"Fetching stock data for symbol {symbol}...");

                List<Company> companies = await stockTickerService.GetStockDataAsync(symbol);

                Console.WriteLine($"Stock data for symbol {symbol}:");
                foreach (var company in companies)
                {
                    Console.WriteLine($"Symbol: {company.Symbol}, " +
                        $"Name: {company.Name}, Type: {company.Type}, " +
                        $"Region: {company.Region}, Market Open: {company.MarketOpen}, " +
                        $"Market Close: {company.MarketClose}, Timezone: {company.Timezone}, " +
                        $"Currency: {company.Currency}, Match Score: {company.MatchScore}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
