using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int result = 0;

        for (int i = 0; i < 5; i++)
        {
            number = int.Parse(Console.ReadLine());
            result += number;
        }
        Console.WriteLine(result);
    }
}