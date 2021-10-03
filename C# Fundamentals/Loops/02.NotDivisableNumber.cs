using System;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write($"{i} ");
            }
        }
    }
}