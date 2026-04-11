using System;//nnnn
namespace QuickMartApp
{
    public class SaleTransaction
    {
        public string InvoiceNo;
        public string CustomerName;
        public string ItemName;
        public int Quantity;
        public decimal PurchaseAmountl;
        public decimal SellingAmount;
        public string ProfitOrLossStatus;
        public decimal ProfitOrLossAmount;
        public decimal ProfitMargingPercent;

    }
    class Program
    {
        static SaleTransaction LastTransaction;
        static bool HasLastTransaction;

        static void Main(string[] args)
        {
            bool exit=false;

            Console.WriteLine("Enter Invoice number : ");
            while(!exit)
            {
                Console.WriteLine("======QuickMart Traiders=====");
                Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Calculate Profit/Losss (Recompute & Print)");
                Console.WRiteLine("4. Exit");

                string choice=Console.ReadLine();
                switch(choice)
                {
                    case "1":
                    CreateNewTransaction();
                    break;
                    case "2":
                    ViewLastTransaction();
                    break;
                    case "3":
                    CalculateProfitLoss();
                    break;
                    case "4":
                    Exit = true;
                    Console.WriteLine("Thank you. Application Closed Normally.");
                    break;
                    default:
                    Console.WriteLine("Invalid Option. Please Try Again.");
                    break;                                       
                }
            }
        }
        static void CreateNewTransaction()
        {
            SaleTransaction transaction = new SaleTransaction();

            Console.WriteLine("Enter Invoice No: ");
            transaction.InvoiceNo = Console.ReadLine();
            if (string.IsNullOrEmpty(transaction.InvoiceNo))
            {
                Console.WriteLine("Error: Invoice No cannot be empty.");
                return;
            }

            Console.WriteLine("Enter Customer Name: ");
            transaction.CustomerName = Console.ReadLine();

            Console.WriteLine("Enter Item Name: ");
            transaction.ItemName = Console.ReadLine();

            Console.WriteLine("Enter Quantity: ");
            if (!int.TryParse(Console.ReadLine(), out transaction.Quantity) || transaction.Quantity <= 0)
            {
                Console.WriteLine("Error: Quantity must be > 0.");
                return;
            }

            Console.WriteLine("Enter Purchase Amount (total): ");
            if (!decimal.TryParse(Console.ReadLine(), out transaction.PurchaseAmount) || transaction.PurchaseAmount <= 0)
            {
                Console.WriteLine("Error: Purchase Amount must be > 0.");
                return;
            }

            Console.WriteLine("Enter Selling Amount (total): ");
            if (!decimal.TryParse(Console.ReadLine(), out transaction.SellingAmount) || transaction.SellingAmount < 0)
            {
                Console.WriteLine("Error: Selling Amount must be >= 0.");
                return;
            }

            PerformCalculations(transaction);

            LastTransaction = transaction;
            HasLastTransaction = true;

            Console.WriteLine("Transaction saved successfully.");
            Console.WriteLine("Status: " + transaction.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: {0:F2}", transaction.ProfitOrLossAmount);
            Console.WriteLine("Profit Margin (%): {0:F2}", transaction.ProfitMarginPercent);
        }

        static void ViewLastTransaction()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            Console.WriteLine("\nLast Transaction");
            Console.WriteLine("InvoiceNo: " + LastTransaction.InvoiceNo);
            Console.WriteLine("Customer: " + LastTransaction.CustomerName);
            Console.WriteLine("Item: " + LastTransaction.ItemName);
            Console.WriteLine("Quantity: " + LastTransaction.Quantity);
            Console.WriteLine("Purchase Amount: {0:F2}", LastTransaction.PurchaseAmount);
            Console.WriteLine("Selling Amount: {0:F2}", LastTransaction.SellingAmount);
            Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: {0:F2}", LastTransaction.ProfitOrLossAmount);
            Console.WriteLine("Profit Margin (%): ", LastTransaction.ProfitMarginPercent);
        }

        static void CalculateProfitLoss()
        {
            if (!HasLastTransaction)
            {
                Console.WriteLine("No transaction available. Please create a new transaction first.");
                return;
            }

            PerformCalculations(LastTransaction);

            Console.WriteLine("\nRecomputed Result:");
            Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: {0:F2}", LastTransaction.ProfitOrLossAmount);
            Console.WriteLine("Profit Margin (%): {0:F2}", LastTransaction.ProfitMarginPercent);
        }

        static void PerformCalculations(SaleTransaction transaction)
        {
            if (transaction.SellingAmount > transaction.PurchaseAmount)
            {
                transaction.ProfitOrLossStatus = "PROFIT";
                transaction.ProfitOrLossAmount = transaction.SellingAmount - transaction.PurchaseAmount;
            }
            else if (transaction.SellingAmount < transaction.PurchaseAmount)
            {
                transaction.ProfitOrLossStatus = "LOSS";
                transaction.ProfitOrLossAmount = transaction.PurchaseAmount - transaction.SellingAmount;
            }
            else
            {
                transaction.ProfitOrLossStatus = "BREAK-EVEN";
                transaction.ProfitOrLossAmount = 0;
            }

            transaction.ProfitMarginPercent = (transaction.ProfitOrLossAmount / transaction.PurchaseAmount) * 100;
        }

    }
}