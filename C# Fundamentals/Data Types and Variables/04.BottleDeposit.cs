using System;

class Program
{
    static void Main(string[] args)
    {
        double halfLiterBottles = double.Parse(Console.ReadLine());
        double literBottles = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("{0:0.00}", 
            (halfLiterBottles * 0.1) + 
            (literBottles * 0.25)));
    }
}