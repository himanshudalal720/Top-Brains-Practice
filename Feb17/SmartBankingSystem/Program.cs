using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<BankAccount> accounts = new List<BankAccount>();

    static void Main()
    {
        SeedData();
        Menu();
    }

    static void SeedData()
    {
        accounts.Add(new SavingsAccount { AccountNumber = "S1", CustomerName = "Rahul", Balance = 80000 });
        accounts.Add(new CurrentAccount { AccountNumber = "C1", CustomerName = "Ramesh", Balance = 60000 });
        accounts.Add(new LoanAccount { AccountNumber = "L1", CustomerName = "Amit", Balance = 100000 });
        accounts.Add(new SavingsAccount { AccountNumber = "S2", CustomerName = "Rita", Balance = 40000 });
    }

    static void Menu()
    {
        while (true)
        {
            Console.WriteLine("\n1. Show All Accounts");
            Console.WriteLine("2. LINQ Queries");
            Console.WriteLine("3. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    accounts.ForEach(a => Console.WriteLine(a));
                    break;

                case "2":
                    RunLinqQueries();
                    break;

                case "3":
                    return;
            }
        }
    }

    static void RunLinqQueries()
    {
        Console.WriteLine("\nAccounts > 50,000:");
        var highBalance = accounts.Where(a => a.Balance > 50000);
        foreach (var acc in highBalance)
            Console.WriteLine(acc);

        Console.WriteLine("\nTotal Bank Balance:");
        Console.WriteLine(accounts.Sum(a => a.Balance));

        Console.WriteLine("\nTop 3 Highest Balance:");
        var top3 = accounts.OrderByDescending(a => a.Balance).Take(3);
        foreach (var acc in top3)
            Console.WriteLine(acc);

        Console.WriteLine("\nGrouped by Account Type:");
        var grouped = accounts.GroupBy(a => a.GetType().Name);
        foreach (var group in grouped)
        {
            Console.WriteLine(group.Key);
            foreach (var acc in group)
                Console.WriteLine(acc);
        }

        Console.WriteLine("\nCustomers starting with R:");
        var rCustomers = accounts.Where(a => a.CustomerName.StartsWith("R"));
        foreach (var acc in rCustomers)
            Console.WriteLine(acc);
    }
}
