using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int sequence = 1;
        int maxSequence = 1;

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
                sequence++;

            if (maxSequence < sequence)
                maxSequence = sequence;

            else
                sequence = 1;

        }
        Console.WriteLine(maxSequence);
    }
}