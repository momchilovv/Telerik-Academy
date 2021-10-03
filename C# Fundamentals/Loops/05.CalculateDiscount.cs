using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int items = int.Parse(Console.ReadLine());
        List<double> discountPrices = new List<double>();

        double input = 0;

        for (int i = 1; i <= items; i++)
        {
            input = double.Parse(Console.ReadLine());

            discountPrices.Add((input / 100) * 35);
        }

        foreach (var item in discountPrices)
        {
            Console.WriteLine($"{item:0.00}");
        }
    }
}