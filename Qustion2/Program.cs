using System;
class Program
{
    static int SumOfDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        int count = 0;

        for (int x = m; x <= n; x++)
        {
            if (!IsPrime(x))
            {
                int s = SumOfDigits(x);
                int sqSum = SumOfDigits(x * x);
                if (sqSum == s * s)
                    count++;
            }
        }
        Console.WriteLine(count);
    }
}
