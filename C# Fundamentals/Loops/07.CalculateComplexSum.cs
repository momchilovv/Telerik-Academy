using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double result = 1;
        double n = 0;
        double sum = 0;

        for (int i = 1; i <= number; i++)
        {
            result = result * i;

            n += result / Math.Pow(x, i);
            sum = 1 + (n);
        }
        Console.WriteLine($"{sum:0.00000}");
    }
}