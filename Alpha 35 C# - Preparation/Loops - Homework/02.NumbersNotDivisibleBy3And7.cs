using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (i !% 3 != 0 && i !% 7 != 0)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }
}