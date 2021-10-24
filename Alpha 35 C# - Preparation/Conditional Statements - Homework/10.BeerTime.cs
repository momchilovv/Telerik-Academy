using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        try
        {
            DateTime time = DateTime.ParseExact(input, "h:mm tt", CultureInfo.InvariantCulture);

            if (time >= DateTime.Parse("1:00 PM") || time <= DateTime.Parse("3:00 AM")) 
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("invalid time");
        }
    }
}