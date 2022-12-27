using System;
public class Primes
{
    static void Main()
    {
        Console.WriteLine("Enter a value to count the primes ");
        int a = int.Parse(Console.ReadLine());
        bool[] primes = new bool[a + 1];
        for (int i = 0; i < primes.Length; i++)
        {
            primes[i] = true;
        }
        for (int i = 2; i < Math.Sqrt(a) + 1; i++)
        {
            if (primes[i - 1])
            {
                for (int j = (int)Math.Pow(i, 2); j <= a; j += i)
                {
                    primes[j - 1] = false;
                }
            }
        }
        int count = 0;
        for (int i = 2; i < primes.Length; i++)
        {
            if (primes[i - 1])
            {
                Console.WriteLine(i);
                count++;
            }
        }
        Console.WriteLine($"There are {count} primes up to {a}");
    }
}
