using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int values = int.Parse(Console.ReadLine());
        List<double> numbers = new List<double>();

        double input = 0;

        for (int i = 1; i <= values; i++)
        {
            input = double.Parse(Console.ReadLine());
            numbers.Add(input);
        }
        Console.WriteLine($"min={numbers.Min():0.00}");
        Console.WriteLine($"max={numbers.Max():0.00}");
        Console.WriteLine($"sum={numbers.Sum():0.00}");
        Console.WriteLine($"avg={numbers.Average():0.00}");
    }
}