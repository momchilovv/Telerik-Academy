using System;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a <= b)
        {
            Console.WriteLine($"{a} {b}");
        }
        else
        {
            Console.WriteLine($"{b} {a}");
        }
    }
}