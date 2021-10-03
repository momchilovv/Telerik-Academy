using System;

class Program
{
    static void Main(string[] args)
    {
        string inputCard = Console.ReadLine();

        if (inputCard == "J")
            inputCard = "11";
        else if (inputCard == "Q")
            inputCard = "12";
        else if (inputCard == "K")
            inputCard = "13";
        else if (inputCard == "A")
            inputCard = "14";

        for (int i = 2; i <= int.Parse(inputCard); i++)
        {
            if (i >= 11)
            {
                switch (i)
                {
                    case 11:
                        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                        break;
                    case 12:
                        Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                        break;
                    case 13:
                        Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                        break;
                    case 14:
                        Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"{i} of spades, {i} of clubs, {i} of hearts, {i} of diamonds");
            }
        }
    }
}