using System;

class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        int secondsPerDay = 86400;
        int secondsPerHour = 3600;
        int secondsPerMinute = 60;

        int result = (days * secondsPerDay) + (hours * secondsPerHour) +
            (minutes * secondsPerMinute) + seconds;

        Console.WriteLine(result);
    }
}