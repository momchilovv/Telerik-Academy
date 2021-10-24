using System;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double sum, x1, x2;

        sum = b * b - (4 * a * c);

        if (sum >= 0)
        {
            x1 = (-b - Math.Sqrt(sum)) / (2 * a);
            x2 = (-b + Math.Sqrt(sum)) / (2 * a);

            if (x1 == 0)
            {
                x1 = 0;
            }
            else if (x2 == 0)
            {
                x2 = 0;
            }

            Console.WriteLine($"x1={x1}; x2={x2}");
        }
    }
}