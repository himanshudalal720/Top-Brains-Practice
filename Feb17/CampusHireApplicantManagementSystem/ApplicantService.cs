using System;
using System.Collections.Generic;
using System.Linq;

namespace CampusHireApplicantManagementSystem
{
    // Service class for managing applicants
    public class ApplicantService
    {
        private List<Applicant> applicants;

        public ApplicantService()
        {
            applicants = FileHelper.LoadFromFile();
        }

        // Add new applicant
        public void AddApplicant(Applicant applicant)
        {
            applicants.Add(applicant);
            FileHelper.SaveToFile(applicants);
            Console.WriteLine("Applicant Added Successfully!");
        }

        // Display all applicants
        public void DisplayAll()
        {
            if (!applicants.Any())
            {
                Console.WriteLine("No applicants found.");
                return;
            }

            foreach (var a in applicants)
            {
                Console.WriteLine($"ID: {a.ApplicantId}, Name: {a.Name}, Current: {a.CurrentLocation}, Preferred: {a.PreferredLocation}, Skill: {a.CoreCompetency}, Year: {a.PassingYear}");
            }
        }

        // Search by ID
        public Applicant Search(string id)
        {
            return applicants.FirstOrDefault(a => a.ApplicantId == id);
        }

        // Update applicant
        public void Update(string id, Applicant updated)
        {
            var applicant = Search(id);
            if (applicant != null)
            {
                applicant.Name = updated.Name;
                applicant.CurrentLocation = updated.CurrentLocation;
                applicant.PreferredLocation = updated.PreferredLocation;
                applicant.CoreCompetency = updated.CoreCompetency;
                applicant.PassingYear = updated.PassingYear;

                FileHelper.SaveToFile(applicants);
                Console.WriteLine("Applicant Updated Successfully!");
            }
            else
            {
                Console.WriteLine("Applicant Not Found.");
            }
        }

        // Delete applicant
        public void Delete(string id)
        {
            var applicant = Search(id);
            if (applicant != null)
            {
                applicants.Remove(applicant);
                FileHelper.SaveToFile(applicants);
                Console.WriteLine("Applicant Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Applicant Not Found.");
            }
        }
    }
}
