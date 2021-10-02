using System;

class Program
{
    static void Main(string[] args)
    {
        double price = double.Parse(Console.ReadLine());
        double customerPaid = double.Parse(Console.ReadLine());

        double totalChange = customerPaid - price;

        int counter = 0;
        totalChange = totalChange * 100;

        for (int i = 0; i <= totalChange + 2; i++)
        {
            if (totalChange >= 100)
            {
                totalChange = totalChange / 100;
                counter = (int)totalChange;
                totalChange = (totalChange * 100) % 100;
                Console.WriteLine($"{counter} x 1 lev");
            }
            else if (totalChange >= 50)
            {
                totalChange = totalChange / 50;
                counter = (int)totalChange;
                totalChange = (totalChange * 50) % 50;
                Console.WriteLine($"{counter} x 50 stotinki");
            }
            else if (totalChange >= 20)
            {
                totalChange = totalChange / 20;
                counter = (int)totalChange;
                totalChange = (totalChange * 20) % 20;
                Console.WriteLine($"{counter} x 20 stotinki");
            }
            else if (totalChange >= 10)
            {
                totalChange = totalChange / 10;
                counter = (int)totalChange;
                totalChange = (totalChange * 10) % 10;
                Console.WriteLine($"{counter} x 10 stotinki");
            }
            else if (totalChange >= 5)
            {
                totalChange = totalChange / 5;
                counter = (int)totalChange;
                totalChange = (totalChange * 5) % 5;
                Console.WriteLine($"{counter} x 5 stotinki");
            }
            else if (totalChange >= 2)
            {
                totalChange = totalChange / 2;
                counter = (int)totalChange;
                totalChange = (totalChange * 2) % 2;
                Console.WriteLine($"{counter} x 2 stotinki");
            }
            else if (totalChange >= 1)
            {
                totalChange = totalChange / 1;
                counter = (int)totalChange;
                totalChange = (totalChange * 1) % 1;
                Console.WriteLine($"{counter} x 1 stotinka");
            }
        }
    }
}