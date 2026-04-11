using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CampusHireApplicantManagementSystem
{
    // Handles file save and load
    public static class FileHelper
    {
        private static string filePath = "applicants.json";

        // Save data to file
        public static void SaveToFile(List<Applicant> applicants)
        {
            string json = JsonSerializer.Serialize(applicants);
            File.WriteAllText(filePath, json);
        }

        // Load data from file
        public static List<Applicant> LoadFromFile()
        {
            if (!File.Exists(filePath))
                return new List<Applicant>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Applicant>>(json)
                   ?? new List<Applicant>();
        }
    }
}
