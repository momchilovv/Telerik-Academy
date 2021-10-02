using System;

class Program
{
    static void Main()
    {
        double milesPerGalon = double.Parse(Console.ReadLine());

        double mileToKm = 1.6;
        double gallonToLiters = 4.54;
        double kml = (100 * gallonToLiters) / (mileToKm * milesPerGalon);

        Console.WriteLine(Math.Floor(kml) + " litres per 100 km");
    }
}