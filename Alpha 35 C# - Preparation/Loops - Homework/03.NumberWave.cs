using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.Write($"{i} ");
        }
        for (int i = number - 1; i >= 1; i--)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }
}