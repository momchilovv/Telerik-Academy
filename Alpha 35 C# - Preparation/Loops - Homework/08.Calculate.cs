using System;

class Program
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double result = 1;
        double factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = 1; 
            for (int j = i; j >= 1; j--)
            {
                factorial *= j;
            }
            result += factorial / Math.Pow(x, i);
        }
        Console.WriteLine($"{result:f5}");
    } 
}