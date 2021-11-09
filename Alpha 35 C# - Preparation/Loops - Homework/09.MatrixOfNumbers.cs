using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int j;

        for (int i = 1; i <= number; i++)
        {
            for (j = i; j <= number; j++)
            {
                Console.Write($"{j} ");
            }
            for (int k = i - 1; k >= 1; k--)
            {
                Console.Write($"{j} ");
                j++;
            }
            Console.WriteLine();
        }
    }
}