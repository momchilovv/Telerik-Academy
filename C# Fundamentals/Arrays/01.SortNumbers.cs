using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        Console.WriteLine(string.Join(", ", numbers.OrderByDescending(n => n)));
    }
}