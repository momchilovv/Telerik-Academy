using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();
        double number;

        for (int i = 0; i < 5; i++)
        {
            number = double.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        Console.WriteLine(numbers.Max());
    }
}