using System;
class Program
{
    public static void Main(string[] args)
    {
        try
        {
            CricketMatch match = new CricketMatch();
            string input = Console.ReadLine();
            string[] scores = input.Split(' ');

            foreach (string s in scores)
            {
                int score = Convert.ToInt32(s);
                match.AddPlayerScore(score);
            }
            int totalScore = match.CalculateTotalScore();
            Console.WriteLine($"Total score of the cricket team: {totalScore}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }



        // try
        // {
        //     double temperature = Convert.ToDouble(Console.ReadLine());
        //     string conversionType = Console.ReadLine();
        //     if (conversionType == "F")
        //     {
        //         double celsius = (temperature - 32) * 5 / 9;
        //         Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
        //     }
        //     else if (conversionType == "C")
        //     {
        //         double fahrenheit = (temperature * 9 / 5) + 32;
        //         Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid conversion type. Please enter 'F' or 'C'.");
        //     }
        // }
        // catch (SystemException ex)

        // {
        //     Console.WriteLine("Error: Invalid input provided.");
        //     Console.WriteLine($"Exception Message: {ex.Message}");
            
        // }
    }
}
