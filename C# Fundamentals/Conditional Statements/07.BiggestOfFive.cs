using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double fourthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());

        List<double> numbers = new List<double>()
        {
            firstNumber,
            secondNumber,
            thirdNumber,
            fourthNumber,
            fifthNumber
        };
        Console.WriteLine(numbers.Max());
    }
}