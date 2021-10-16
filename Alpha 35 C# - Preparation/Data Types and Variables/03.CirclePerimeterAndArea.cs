using System;

class Program
{
    static void Main(string[] args)
    {
        double radius = double.Parse(Console.ReadLine());

        double perimeter;
        double area;

        perimeter = Math.PI * (2 * radius);
        area = (radius * radius) * Math.PI;

        Console.WriteLine($"{perimeter:f2}");
        Console.WriteLine($"{area:f2}");
    }
}