using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please choose a type:\r\n" +
            "1 --> int\r\n" +
            "2 --> double\r\n" +
            "3 --> string\r\n");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.Write("Please enter an int: ");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer + 1);
                break;
            case "2":
                Console.Write("Please enter a double: ");
                double doubl3 = double.Parse(Console.ReadLine());
                Console.WriteLine(doubl3 + 1);
                break;
            case "3":
                Console.Write("Please enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
                break;
            default:
                break;
        }
    }
}