using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTicker
{
    public class StockTickerService : IStockTickerService
    {
        string APIKey = "DBHPBDI3UJ24HSUW";
        string QUERY_URL = "";
 
        private readonly HttpClient httpClient;

        public StockTickerService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Company>> GetStockDataAsync(string symbol)
        {
            QUERY_URL = $"https://www.alphavantage.co/query?" +
                $"function=SYMBOL_SEARCH&keywords={symbol}&apikey={APIKey}";
            Uri queryUri = new Uri(QUERY_URL);
            HttpResponseMessage response = await httpClient.GetAsync(queryUri);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<RootObject>(jsonResponse);
                return result.BestMatches;
            }
            else
            {
                throw new Exception($"Failed to fetch stock data for symbol {symbol}. Status code: {response.StatusCode}");
            }
        }
    }
}
