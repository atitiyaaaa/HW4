using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        int[] populations = Console.ReadLine().Split().Select(int.Parse).ToArray();

        // Start with a window of size K * 2 + 1 or N
        int windowSize = Math.Min(K * 2 + 1, N);

        int maxCustomers = 0;
        for (int i = 0; i <= N - windowSize; i++)
        {
            int customers = 0;
            for (int j = 0; j < windowSize; j++)
            {
                customers += populations[i + j];
            }
            maxCustomers = Math.Max(maxCustomers, customers);
        }

        Console.WriteLine(maxCustomers);
    }
}