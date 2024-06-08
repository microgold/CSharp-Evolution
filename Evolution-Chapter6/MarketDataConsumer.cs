public class MarketDataConsumer
{
    public async Task DisplayMarketDataAsync()
    {
        var marketDataService = new MarketDataService();
        string symbol = "AAPL";

        await foreach (var data in marketDataService.StreamMarketDataAsync(symbol))
        {
            Console.WriteLine($"Symbol: {data.Symbol}, Price: {data.Price}, Time: {data.Timestamp}");
        }
    }
}