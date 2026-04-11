using System;
using System.Collections.Generic;
using System.Linq;

namespace StockTradingPortfolioSystem
{
    // Custom Exception

    class InvalidTradeException : Exception
    {
        public InvalidTradeException(string message) : base(message) { }
    }

    // Risk Strategy Interface

    interface IRiskStrategy
    {
        double CalculateRisk(List<Transaction> transactions);
    }

    // Conservative Risk Strategy

    class ConservativeRiskStrategy : IRiskStrategy
    {
        public double CalculateRisk(List<Transaction> transactions)
        {
            return transactions.Sum(t => Math.Abs(t.Amount)) * 0.05;
        }
    }

    // Aggressive Risk Strategy

    class AggressiveRiskStrategy : IRiskStrategy
    {
        public double CalculateRisk(List<Transaction> transactions)
        {
            return transactions.Sum(t => Math.Abs(t.Amount)) * 0.15;
        }
    }

    // Investor Class

    class Investor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Stock Class

    class Stock
    {
        public string Symbol { get; set; }
        public double Price { get; private set; }

        // Event for price change

        public event Action<string, double> OnPriceChanged;

        public void UpdatePrice(double newPrice)
        {
            Price = newPrice;
            OnPriceChanged?.Invoke(Symbol, newPrice);
        }
    }

    // Transaction Class

    class Transaction
    {
        public Investor Investor { get; set; }
        public Stock Stock { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public bool IsBuy { get; set; }

        public double Amount => Quantity * Price * (IsBuy ? -1 : 1);
    }

    // Portfolio Class

    class Portfolio
    {
        public Investor Investor { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public IRiskStrategy RiskStrategy { get; set; }

        public void AddTransaction(Transaction transaction)
        {
            if (transaction.Date > DateTime.Now)
                throw new InvalidTradeException("Transaction date cannot be future.");

            int ownedShares = Transactions
                .Where(t => t.Stock.Symbol == transaction.Stock.Symbol)
                .Sum(t => t.IsBuy ? t.Quantity : -t.Quantity);

            if (!transaction.IsBuy && transaction.Quantity > ownedShares)
                throw new InvalidTradeException("Cannot sell more shares than owned.");

            Transactions.Add(transaction);
        }

        public double CalculateNetProfit()
        {
            return Transactions.Sum(t => t.Amount);
        }

        public double CalculateRisk()
        {
            return RiskStrategy.CalculateRisk(Transactions);
        }
    }

    // Program

    class Program
    {
        static List<Investor> investors = new List<Investor>();
        static List<Stock> stocks = new List<Stock>();
        static List<Transaction> transactions = new List<Transaction>();
        static Dictionary<string, List<Transaction>> transactionByStock = new Dictionary<string, List<Transaction>>();

        static void Main()
        {
            SeedData();
            SimulateTrading();
            RunLINQQueries();

            Console.ReadLine();
        }

        // Seed Data

        static void SeedData()
        {
            investors.Add(new Investor { Id = 1, Name = "Ravi" });
            investors.Add(new Investor { Id = 2, Name = "Amit" });

            var stock1 = new Stock { Symbol = "TCS" };
            var stock2 = new Stock { Symbol = "INFY" };

            stock1.OnPriceChanged += (symbol, price) =>
                Console.WriteLine($"Price Updated: {symbol} = {price}");

            stock2.OnPriceChanged += (symbol, price) =>
                Console.WriteLine($"Price Updated: {symbol} = {price}");

            stock1.UpdatePrice(3500);
            stock2.UpdatePrice(1500);

            stocks.Add(stock1);
            stocks.Add(stock2);

            transactionByStock["TCS"] = new List<Transaction>();
            transactionByStock["INFY"] = new List<Transaction>();
        }

        // Trading Simulation

        static void SimulateTrading()
        {
            var portfolio1 = new Portfolio
            {
                Investor = investors[0],
                RiskStrategy = new ConservativeRiskStrategy()
            };

            var portfolio2 = new Portfolio
            {
                Investor = investors[1],
                RiskStrategy = new AggressiveRiskStrategy()
            };

            try
            {
                var t1 = new Transaction
                {
                    Investor = investors[0],
                    Stock = stocks[0],
                    Quantity = 10,
                    Price = 3500,
                    Date = DateTime.Now,
                    IsBuy = true
                };

                portfolio1.AddTransaction(t1);
                transactions.Add(t1);
                transactionByStock["TCS"].Add(t1);

                var t2 = new Transaction
                {
                    Investor = investors[1],
                    Stock = stocks[1],
                    Quantity = 5,
                    Price = 1500,
                    Date = DateTime.Now,
                    IsBuy = true
                };

                portfolio2.AddTransaction(t2);
                transactions.Add(t2);
                transactionByStock["INFY"].Add(t2);
            }
            catch (InvalidTradeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Net Profit Ravi: {portfolio1.CalculateNetProfit()}");
            Console.WriteLine($"Risk Ravi: {portfolio1.CalculateRisk()}");

            Console.WriteLine($"Net Profit Amit: {portfolio2.CalculateNetProfit()}");
            Console.WriteLine($"Risk Amit: {portfolio2.CalculateRisk()}");
        }

        // LINQ Queries

        static void RunLINQQueries()
        {
            Console.WriteLine("\nMost Profitable Investor:");

            var investorProfit = transactions
                .GroupBy(t => t.Investor)
                .Select(g => new
                {
                    Investor = g.Key.Name,
                    Profit = g.Sum(t => t.Amount)
                })
                .OrderByDescending(x => x.Profit)
                .FirstOrDefault();

            if (investorProfit != null)
                Console.WriteLine($"{investorProfit.Investor} - {investorProfit.Profit}");

            Console.WriteLine("\nStock with Highest Volume:");

            var highestVolume = transactions
                .GroupBy(t => t.Stock.Symbol)
                .Select(g => new
                {
                    Stock = g.Key,
                    Volume = g.Sum(t => t.Quantity)
                })
                .OrderByDescending(x => x.Volume)
                .FirstOrDefault();

            if (highestVolume != null)
                Console.WriteLine($"{highestVolume.Stock} - {highestVolume.Volume}");

            Console.WriteLine("\nTransactions Grouped by Stock:");

            var grouped = transactions.GroupBy(t => t.Stock.Symbol);

            foreach (var group in grouped)
                Console.WriteLine($"{group.Key} - {group.Count()} transactions");

            Console.WriteLine("\nNet Profit/Loss (Using Aggregate):");

            var net = transactions.Aggregate(0.0, (total, t) => total + t.Amount);
            Console.WriteLine(net);

            Console.WriteLine("\nInvestors with Negative Returns:");

            var negativeInvestors = transactions
                .GroupBy(t => t.Investor)
                .Where(g => g.Sum(t => t.Amount) < 0)
                .Select(g => g.Key.Name);

            foreach (var name in negativeInvestors)
                Console.WriteLine(name);
        }
    }
}
