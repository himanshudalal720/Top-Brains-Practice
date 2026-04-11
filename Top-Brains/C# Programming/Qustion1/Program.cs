using System;
using System.Linq;
using System.Text;

class Program
{
    static bool IsVowel(char c)
    {
        return "aeiou".Contains(char.ToLower(c));
    }

    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        var secondSet = second.ToLower().ToHashSet();

        var filtered = first
            .Where(c => IsVowel(c) || !secondSet.Contains(char.ToLower(c)))
            .ToList();

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < filtered.Count; i++)
        {
            if (i == 0 || filtered[i] != filtered[i - 1])
                result.Append(filtered[i]);
        }

        console.WriteLine(result.ToString());
    }
}
