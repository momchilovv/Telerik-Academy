using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        if (input == "J" || input == "Q" || input == "K" || input == "A")
        {
            Console.WriteLine("yes");
        }
        else if (int.Parse(input) >= 2 && int.Parse(input) <= 10)
        {
            Console.WriteLine("yes");
        }        
        else
        {
            Console.WriteLine("no");
        }
    }
}