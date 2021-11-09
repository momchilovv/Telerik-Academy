using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        for (int i = 0, j = input.Length - 1; i < j; i++, j--)
        {
            if (input[i] != input[j])
            {
                Console.WriteLine("No");
                Environment.Exit(input[i]);
            }
        }
        Console.WriteLine("Yes");
    }
}