using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        int currentNumber = 0;
        List<int> largestThree = new List<int>();

        for (int i = 0; i < input; i++)
        {
            currentNumber = int.Parse(Console.ReadLine());
            numbers.Add(currentNumber);
        }

        for (int i = 1; i <= 3; i++)
        {
            largestThree.Add(numbers.Max());
            numbers.Remove(numbers.Max());
        }
        Console.WriteLine($"{largestThree[0]}, {largestThree[1]} and {largestThree[2]}");
    }
}