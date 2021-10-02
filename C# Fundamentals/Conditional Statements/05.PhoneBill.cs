using System;

class Program
{
    static void Main(string[] args)
    {
        int totalTextMessages = int.Parse(Console.ReadLine());
        int totalMinutes = int.Parse(Console.ReadLine());

        int additionalMessages = totalTextMessages - 20;
        int additionalMinutes = totalMinutes - 60;

        double totalPaid = 12.00;
        double paidForMessages = 0;
        double paidForMinutes = 0;
        double bill = 0;
        double tax = 0;

        for (int i = 0; i < additionalMessages; i++)
        {
            bill += 0.06;
            paidForMessages += 0.06;
        }
        for (int i = 0; i < additionalMinutes; i++)
        {
            bill += 0.10;
            paidForMinutes += 0.10;
        }
        tax = (bill / 100) * 20;

        totalPaid += bill + tax;

        if (additionalMinutes < 0)
        {
            additionalMinutes = 0;
        }
        if (additionalMessages < 0)
        {
            additionalMessages = 0;
        }

        Console.WriteLine($"{additionalMessages} additional messages for {paidForMessages:0.00} levas");
        Console.WriteLine($"{additionalMinutes} additional minutes for {paidForMinutes:0.00} levas");
        Console.WriteLine($"{tax:0.00} additional taxes");
        Console.WriteLine($"{totalPaid:0.00} total bill");
    }
}