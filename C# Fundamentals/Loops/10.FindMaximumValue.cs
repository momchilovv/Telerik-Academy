using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        int sNumbers = 0;

        for (int i = 0; i < input; i++)
        {
            sNumbers = int.Parse(Console.ReadLine());
            numbers.Add(sNumbers);
        }
        Console.WriteLine(numbers.Max());
    }
}