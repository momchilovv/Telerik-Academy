using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < 2; i++)
        {
            int a = int.Parse(Console.ReadLine());
            numbers.Add(a);
        }
        Console.WriteLine(numbers.Max());
    }
}