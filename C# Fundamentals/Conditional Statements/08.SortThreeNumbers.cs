using System;

class Program
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber}");
            }
            else
            {
                Console.WriteLine($"{firstNumber} {thirdNumber} {secondNumber}");
            }
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine($"{secondNumber} {firstNumber} {thirdNumber}");
            }
            else
            {
                Console.WriteLine($"{secondNumber} {thirdNumber} {firstNumber}");
            }
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            if (secondNumber > firstNumber)
            {
                Console.WriteLine($"{thirdNumber} {secondNumber} {firstNumber}");
            }
            else
            {
                Console.WriteLine($"{thirdNumber} {firstNumber} {secondNumber}");
            }
        }
    }
}