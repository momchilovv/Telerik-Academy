using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        bool isNumber = int.TryParse(input, out int number);

        if (isNumber)
        {
            Console.WriteLine(number + 1);
        }
        else
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reverseString = new string(charArray);
            Console.WriteLine(reverseString);
        }
    }
}