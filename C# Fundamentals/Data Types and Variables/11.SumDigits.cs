using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        var inputList = input.Select(digit => int.Parse(digit.ToString()));

        Console.WriteLine(inputList.Sum());
    }
}