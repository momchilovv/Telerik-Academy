using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        Array.Sort(input);
        Array.Reverse(input);
        Console.WriteLine($"{input[0]} {input[1]}");
    }
}