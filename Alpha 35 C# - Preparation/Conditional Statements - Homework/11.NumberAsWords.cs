using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        string toWords = "";

        if (number == 0)
            Console.WriteLine("Zero");

        if ((number / 100) > 0)
        {
            string[] hundreds = {"one hundred", "two hundred", "three hundred", "four hundred", "five hundred",
                            "six hundred", "seven hundred", "eight hundred", "nine hundred" };
            toWords += hundreds[(number / 100) - 1];
            number %= 100;
        }
        if (number > 0)
        {
            if (toWords != "")
                toWords += " and ";

            string[] twentys = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                toWords += twentys[number];
            else
            {
                toWords += tens[number / 10];
                if ((number % 10) > 0)
                    toWords += " " + twentys[number % 10];
            }
            Console.WriteLine(string.Concat(toWords[0].ToString().ToUpper(), toWords.AsSpan(1)));
        }
    }
}