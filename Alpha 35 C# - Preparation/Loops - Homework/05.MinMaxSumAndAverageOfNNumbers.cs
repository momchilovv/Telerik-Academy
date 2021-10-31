using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine(
            $"min = {numbers.Min()}\r\n" +
            $"max = {numbers.Max()}\r\n" +
            $"sum = {numbers.Sum()}\r\n" +
            $"avg = {numbers.Average():f2}\r\n");
    }
}