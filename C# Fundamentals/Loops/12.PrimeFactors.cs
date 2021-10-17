using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        List<int> primeFactors = new List<int>();

        while (number % 5 == 0)
        {
            primeFactors.Add(5);
            number /= 5;
        }

        while (number % 2 == 0)
        {
            primeFactors.Add(2);
            number /= 2;
        }

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            while (number % i == 0)
            {
                primeFactors.Add(i);
                number /= i;
            }
        }

        if (number > 2)
        {
            primeFactors.Add(number);
        }

        foreach (var item in primeFactors.OrderBy(a => a))
        {
            Console.WriteLine(item);
        }
    }
}