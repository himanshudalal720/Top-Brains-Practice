using System;
using System.Collections.Generic;
using System.Linq;

public interface IFinancialInstrument
{
    string Symbol { get; }
    decimal CurrentPrice { get; }
    InstrumentType Type { get; }
}

public enum InstrumentType { Stock, Bond, Option, Future }

// 1. Generic portfolio
public class Portfolio<T> where T : IFinancialInstrument
{
    private Dictionary<T, int> _holdings = new(); // Instrument -> Quantity
    
    // TODO: Buy instrument
    public void Buy(T instrument, int quantity, decimal price)
    {
        // Validate: quantity > 0, price > 0
        // Add to holdings or update quantity

        if (quantity <= 0 || price <= 0)
            throw new ArgumentException("Quantity and price must be positive.");

        if (_holdings.ContainsKey(instrument))
            _holdings[instrument] += quantity;
        else
            _holdings[instrument] = quantity;
    }
    
    // TODO: Sell instrument
    public decimal? Sell(T instrument, int quantity, decimal currentPrice)
    {
        // Validate: enough quantity
        // Remove/update holdings
        // Return proceeds (quantity * currentPrice)

        if (!_holdings.ContainsKey(instrument) || _holdings[instrument] < quantity)
            return null;

        _holdings[instrument] -= quantity;

        if (_holdings[instrument] == 0)
            _holdings.Remove(instrument);

        return quantity * currentPrice;
    }
    
    // TODO: Calculate total value
    public decimal CalculateTotalValue()
    {
        // Sum of (quantity * currentPrice) for all holdings

        return _holdings.Sum(h => h.Key.CurrentPrice * h.Value);
    }
    
    // TODO: Get top performing instrument
    public (T instrument, decimal returnPercentage)? GetTopPerformer(
        Dictionary<T, decimal> purchasePrices)
    {
        // Calculate return percentage for each
        // Return highest performer

        if (!purchasePrices.Any())
            return null;

        var performance = _holdings
            .Where(h => purchasePrices.ContainsKey(h.Key))
            .Select(h =>
            {
                var purchasePrice = purchasePrices[h.Key];
                var returnPercent = ((h.Key.CurrentPrice - purchasePrice) / purchasePrice) * 100;
                return (instrument: h.Key, returnPercentage: returnPercent);
            });

        return performance.OrderByDescending(p => p.returnPercentage).FirstOrDefault();
    }

    public Dictionary<T, int> GetHoldings() => _holdings;
}

// 2. Specialized instruments
public class Stock : IFinancialInstrument
{
    public string Symbol { get; set; }
    public decimal CurrentPrice { get; set; }
    public InstrumentType Type => InstrumentType.Stock;
    public string CompanyName { get; set; }
    public decimal DividendYield { get; set; }
}

public class Bond : IFinancialInstrument
{
    public string Symbol { get; set; }
    public decimal CurrentPrice { get; set; }
    public InstrumentType Type => InstrumentType.Bond;
    public DateTime MaturityDate { get; set; }
    public decimal CouponRate { get; set; }
}

// 3. Generic trading strategy
public class TradingStrategy<T> where T : IFinancialInstrument
{
    // TODO: Execute strategy on portfolio
    public void Execute(Portfolio<T> portfolio, 
        Func<T, bool> buyCondition,
        Func<T, bool> sellCondition)
    {
        // For each instrument in market data
        // Apply buy/sell conditions
        // Execute trades

        foreach (var holding in portfolio.GetHoldings().ToList())
        {
            var instrument = holding.Key;

            if (sellCondition(instrument))
            {
                portfolio.Sell(instrument, holding.Value, instrument.CurrentPrice);
                Console.WriteLine($"Sold {instrument.Symbol}");
            }
            else if (buyCondition(instrument))
            {
                portfolio.Buy(instrument, 1, instrument.CurrentPrice);
                Console.WriteLine($"Bought more of {instrument.Symbol}");
            }
        }
    }
    
    // TODO: Calculate risk metrics
    public Dictionary<string, decimal> CalculateRiskMetrics(IEnumerable<T> instruments)
    {
        // Return: Volatility, Beta, Sharpe Ratio

        var prices = instruments.Select(i => i.CurrentPrice).ToList();

        if (!prices.Any())
            return new Dictionary<string, decimal>();

        decimal average = prices.Average();
        decimal variance = prices.Sum(p => (p - average) * (p - average)) / prices.Count;
        decimal volatility = (decimal)Math.Sqrt((double)variance);

        return new Dictionary<string, decimal>
        {
            { "Volatility", volatility },
            { "Beta", 1.1m },          // simplified assumption
            { "SharpeRatio", average != 0 ? average / volatility : 0 }
        };
    }
}

// 4. Price history with generics
public class PriceHistory<T> where T : IFinancialInstrument
{
    private Dictionary<T, List<(DateTime, decimal)>> _history = new();
    
    // TODO: Add price point
    public void AddPrice(T instrument, DateTime timestamp, decimal price)
    {
        // Add to history

        if (!_history.ContainsKey(instrument))
            _history[instrument] = new List<(DateTime, decimal)>();

        _history[instrument].Add((timestamp, price));
    }
    
    // TODO: Get moving average
    public decimal? GetMovingAverage(T instrument, int days)
    {
        // Calculate simple moving average

        if (!_history.ContainsKey(instrument))
            return null;

        var prices = _history[instrument]
            .OrderByDescending(p => p.Item1)
            .Take(days)
            .Select(p => p.Item2)
            .ToList();

        if (!prices.Any())
            return null;

        return prices.Average();
    }
    
    // TODO: Detect trends
    public Trend DetectTrend(T instrument, int period)
    {
        // Return: Upward, Downward, Sideways

        if (!_history.ContainsKey(instrument))
            return Trend.Sideways;

        var prices = _history[instrument]
            .OrderByDescending(p => p.Item1)
            .Take(period)
            .Select(p => p.Item2)
            .ToList();

        if (prices.Count < 2)
            return Trend.Sideways;

        if (prices.First() > prices.Last())
            return Trend.Upward;

        if (prices.First() < prices.Last())
            return Trend.Downward;

        return Trend.Sideways;
    }
}

public enum Trend { Upward, Downward, Sideways }

// 5. TEST SCENARIO: Trading simulation
// a) Create portfolio with mixed instruments
// b) Implement buy/sell logic
// c) Create trading strategy with lambda conditions
// d) Track price history
// e) Demonstrate:
//    - Portfolio rebalancing
//    - Risk calculation
//    - Trend detection
//    - Performance comparison

class Program
{
    static void Main()
    {
        var stock1 = new Stock { Symbol = "AAPL", CurrentPrice = 180, CompanyName = "Apple" };
        var stock2 = new Stock { Symbol = "GOOG", CurrentPrice = 140, CompanyName = "Google" };
        var bond1 = new Bond { Symbol = "BOND1", CurrentPrice = 1000, CouponRate = 5 };

        var portfolio = new Portfolio<IFinancialInstrument>();

        portfolio.Buy(stock1, 10, 150);
        portfolio.Buy(stock2, 5, 120);
        portfolio.Buy(bond1, 2, 950);

        Console.WriteLine("Total Value: " + portfolio.CalculateTotalValue());

        var strategy = new TradingStrategy<IFinancialInstrument>();

        strategy.Execute(
            portfolio,
            buyCondition: i => i.CurrentPrice < 150,
            sellCondition: i => i.CurrentPrice > 170
        );

        var history = new PriceHistory<IFinancialInstrument>();

        history.AddPrice(stock1, DateTime.Today.AddDays(-2), 170);
        history.AddPrice(stock1, DateTime.Today.AddDays(-1), 175);
        history.AddPrice(stock1, DateTime.Today, 180);

        Console.WriteLine("Moving Average: " + history.GetMovingAverage(stock1, 3));
        Console.WriteLine("Trend: " + history.DetectTrend(stock1, 3));

        var risk = strategy.CalculateRiskMetrics(
            portfolio.GetHoldings().Keys);

        Console.WriteLine("Risk Metrics:");
        foreach (var r in risk)
            Console.WriteLine($"{r.Key}: {r.Value:F2}");

        Console.ReadKey();
    }
}
