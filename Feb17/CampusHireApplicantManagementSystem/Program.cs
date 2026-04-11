using System;
namespace CampusHireApplicantManagementSystem
{
    // Program
    class Program
    {
        static void Main()
        {
            ApplicantService service = new ApplicantService();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== CampusHire Applicant Management =====");
                Console.WriteLine("1. Add Applicant");
                Console.WriteLine("2. Display All Applicants");
                Console.WriteLine("3. Search Applicant");
                Console.WriteLine("4. Update Applicant");
                Console.WriteLine("5. Delete Applicant");
                Console.WriteLine("6. Exit");

                Console.Write("Choose Option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddApplicant(service);
                        break;

                    case 2:
                        service.DisplayAll();
                        break;

                    case 3:
                        Console.Write("Enter Applicant ID: ");
                        string id = Console.ReadLine();
                        var applicant = service.Search(id);

                        if (applicant != null)
                            Console.WriteLine($"Found: {applicant.Name}, {applicant.CoreCompetency}");
                        else
                            Console.WriteLine("Applicant Not Found.");
                        break;

                    case 4:
                        Console.Write("Enter Applicant ID to Update: ");
                        string updateId = Console.ReadLine();
                        AddApplicant(service, updateId, true);
                        break;

                    case 5:
                        Console.Write("Enter Applicant ID to Delete: ");
                        string deleteId = Console.ReadLine();
                        service.Delete(deleteId);
                        break;

                    case 6:
                        exit = true;
                        break;
                }
            }
        }

        // Method to take input and validate
        static void AddApplicant(ApplicantService service, string existingId = null, bool isUpdate = false)
        {
            string id = existingId ?? GetValidId();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Current Location (Mumbai/Pune/Chennai): ");
            string current = Console.ReadLine();

            Console.Write("Enter Preferred Location: ");
            string preferred = Console.ReadLine();

            Console.Write("Enter Core Competency (.NET/JAVA/ORACLE/Testing): ");
            string competency = Console.ReadLine();

            Console.Write("Enter Passing Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year > DateTime.Now.Year)
            {
                Console.WriteLine("Invalid Passing Year.");
                return;
            }

            Applicant applicant = new Applicant
            {
                ApplicantId = id,
                Name = name,
                CurrentLocation = current,
                PreferredLocation = preferred,
                CoreCompetency = competency,
                PassingYear = year
            };

            if (isUpdate)
                service.Update(id, applicant);
            else
                service.AddApplicant(applicant);
        }

        // Validate Applicant ID
        static string GetValidId()
        {
            while (true)
            {
                Console.Write("Enter Applicant ID (CH123456): ");
                string id = Console.ReadLine();

                if (id.Length == 8 && id.StartsWith("CH"))
                    return id;

                Console.WriteLine("Invalid ID Format!");
            }
        }
    }
}