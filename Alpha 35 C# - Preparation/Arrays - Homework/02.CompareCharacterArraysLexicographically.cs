using System;

class Program
{
    static void Main(string[] args)
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        char[] firstCharArray = new char[first.Length];
        char[] secondCharArray = new char[second.Length];

        if (firstCharArray.Length > secondCharArray.Length)
        {
            Console.WriteLine("Second");
        }
        else if (secondCharArray.Length > firstCharArray.Length)
        {
            Console.WriteLine("First");
        }
        else if (firstCharArray.Length == secondCharArray.Length)
        {
            Console.WriteLine("Equal");
        }
    }
}