using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int? previousItem = null;

        List<int> numbers = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        foreach (var item in numbers)
        {
            if (previousItem < item)
            {
                Console.Write("<");
            }
            else if (previousItem > item)
            {
                Console.Write(">");
            }
            else if (previousItem == item)
            {
                Console.Write("=");
            }
            Console.Write($"{item}");
            previousItem = item;
        }
        Console.WriteLine();
    }
}