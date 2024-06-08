using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution_Chapter6
{
    public class MarketData
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }

        public MarketData(string symbol, decimal price)
        {
            Symbol = symbol;
            Price = price;
            Timestamp = DateTime.Now;
        }
    }
}
