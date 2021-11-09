using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < 3; i++)
        {
            int input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }
        Console.WriteLine(numbers.Max() + numbers.Min());
    }
}