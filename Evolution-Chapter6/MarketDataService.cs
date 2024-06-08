using Evolution_Chapter6;

public class MarketDataService
{
    private readonly Random _random = new Random();

    public async IAsyncEnumerable<MarketData> StreamMarketDataAsync(string symbol)
    {
        // Simulating a stream of market data for a given symbol
        while (true)
        {
            await Task.Delay(_random.Next(500, 2000)); // Simulate variable update intervals

            // Simulate a price change
            decimal priceChange = (decimal)(_random.NextDouble() * 2 - 1); // Random fluctuation between -1 and +1
            decimal newPrice = 100 + priceChange; // Assume the base price is 100

            yield return new MarketData(symbol, newPrice);
        }
    }
}