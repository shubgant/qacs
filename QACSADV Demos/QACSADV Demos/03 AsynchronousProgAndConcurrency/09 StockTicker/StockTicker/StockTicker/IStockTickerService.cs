using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTicker
{
    public interface IStockTickerService
    {
        Task<List<Company>> GetStockDataAsync(string symbol);
    }
}
