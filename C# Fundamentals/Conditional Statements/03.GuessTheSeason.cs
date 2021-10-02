using System;

class Program
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int day = int.Parse(Console.ReadLine());

        if (month == "January" ||
            month == "February" ||
            month == "March" && day <= 19 ||
            month == "December" && day >= 21)
        {
            Console.WriteLine("Winter");
        }
        else if (month == "April" ||
                 month == "May" ||
                 month == "March" && day >= 20 ||
                 month == "June" && day <= 20)
        {
            Console.WriteLine("Spring");
        }
        else if (month == "July" ||
                 month == "August" ||
                 month == "June" && day >= 21 ||
                 month == "September" && day <= 21)
        {
            Console.WriteLine("Summer");
        }
        else
        {
            Console.WriteLine("Autumn");
        }
    }
}