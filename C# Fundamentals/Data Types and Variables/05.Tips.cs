using System;

class Program
{
    static void Main(string[] args)
    {
        int bill = int.Parse(Console.ReadLine());

        Console.WriteLine(bill + (bill * 0.1));
    }
}