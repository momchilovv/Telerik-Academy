using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numberOfValues = int.Parse(Console.ReadLine());
        List<double> values = new List<double>();
        double input = 0;

        for (int i = 1; i <= numberOfValues; i++)
        {
            input = double.Parse(Console.ReadLine());
            values.Add(input);
        }
        Console.WriteLine($"{values.Average():0.00}");
    }
}