using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int sequence = 0;

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] <= input[i + 1])
                sequence++;
            
        }
        if (sequence == input.Length - 1)
            Console.WriteLine("Yes");
        
        else
            Console.WriteLine("No");
    }
}