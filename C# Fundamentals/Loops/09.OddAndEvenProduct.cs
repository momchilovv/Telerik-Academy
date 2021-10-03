using System;

class Program
{
    static void Main(string[] args)
    {
        int numbers = int.Parse(Console.ReadLine());
        int inputNumbers = 0;

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 1; i <= numbers; i++)
        {
            inputNumbers = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenProduct *= inputNumbers;
            }
            else if (i % 2 != 0)
            {
                oddProduct *= inputNumbers;
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine($"yes {evenProduct}");
        }
        else
        {
            Console.WriteLine($"no {oddProduct} {evenProduct}");
        }
    }
}