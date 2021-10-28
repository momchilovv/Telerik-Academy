using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();

        Console.WriteLine(string.Join("", number.Reverse()));
    }
}