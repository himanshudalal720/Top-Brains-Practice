using System;

namespace MediSureApp
{
    public class PatientBill
    {
        public string BillId;
        public string PatientName;
        public bool HasInsurance;
        public decimal ConsultationFee;
        public decimal LabCharges;
        public decimal MedicineCharges;
        public decimal GrossAmount;
        public decimal DiscountAmount;
        public decimal FinalPayable;
    }

    class Program
    {
        static PatientBill LastBill;
        static bool HasLastBill = false;

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== MediSure Clinic Billing ========");
                Console.WriteLine("1. Create New Bill (Enter Patient Details)");
                Console.WriteLine("2. View Last Bill");
                Console.WriteLine("3. Clear Last Bill");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateNewBill();
                        break;
                    case "2":
                        ViewLastBill();
                        break;
                    case "3":
                        ClearLastBill();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Thank you. Application closed normally.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void CreateNewBill()
        {
            PatientBill bill = new PatientBill();

            Console.WriteLine("Enter Bill Id: ");
            bill.BillId = Console.ReadLine();
            if (string.IsNullOrEmpty(bill.BillId))
            {
                Console.WriteLine("Error: Bill ID cannot be empty.");
                return;
            }

            Console.WriteLine("Enter Patient Name: ");
            bill.PatientName = Console.ReadLine();

            Console.WriteLine("Is the patient insured? (Y/N): ");
            string insuredInput = Console.ReadLine().ToUpper();
            bill.HasInsurance = (insuredInput == "Y");

            Console.WriteLine("Enter Consultation Fee: ");
            if (!decimal.TryParse(Console.ReadLine(), out bill.ConsultationFee) || bill.ConsultationFee <= 0)
            {
                Console.WriteLine("Error: Consultation Fee must be > 0.");
                return;
            }

            Console.WriteLine("Enter Lab Charges: ");
            if (!decimal.TryParse(Console.ReadLine(), out bill.LabCharges) || bill.LabCharges < 0)
            {
                Console.WriteLine("Error: Lab Charges must be >= 0.");
                return;
            }

            Console.WriteLine("Enter Medicine Charges: ");
            if (!decimal.TryParse(Console.ReadLine(), out bill.MedicineCharges) || bill.MedicineCharges < 0)
            {
                Console.WriteLine("Error: Medicine Charges must be >= 0.");
                return;
            }

            bill.GrossAmount = bill.ConsultationFee + bill.LabCharges + bill.MedicineCharges;

            if (bill.HasInsurance)
            {
                bill.DiscountAmount = bill.GrossAmount * 0.10m;
            }
            else
            {
                bill.DiscountAmount = 0;
            }

            bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;

            LastBill = bill;
            HasLastBill = true;

            Console.WriteLine("Bill created successfully.");
            Console.WriteLine("Gross Amount: {0:F2}", bill.GrossAmount);
            Console.WriteLine("Discount Amount: {0:F2}", bill.DiscountAmount);
            Console.WriteLine("Final Payable: {0:F2}", bill.FinalPayable);
        }

        static void ViewLastBill()
        {
            if (!HasLastBill)
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
                return;
            }

            Console.WriteLine("\n--- Last Bill Details ---");
            Console.WriteLine("BillId: " + LastBill.BillId);
            Console.WriteLine("Patient: " + LastBill.PatientName);
            Console.WriteLine("Insured: " + (LastBill.HasInsurance ? "Yes" : "No"));
            Console.WriteLine("Consultation Fee: {0:F2}", LastBill.ConsultationFee);
            Console.WriteLine("Lab Charges: {0:F2}", LastBill.LabCharges);
            Console.WriteLine("Medicine Charges: {0:F2}", LastBill.MedicineCharges);
            Console.WriteLine("Gross Amount: {0:F2}", LastBill.GrossAmount);
            Console.WriteLine("Discount Amount: {0:F2}", LastBill.DiscountAmount);
            Console.WriteLine("Final Payable: {0:F2}", LastBill.FinalPayable);
        }

        static void ClearLastBill()
        {
            LastBill = null;
            HasLastBill = false;
            Console.WriteLine("Last bill cleared.");
        }
    }
}
