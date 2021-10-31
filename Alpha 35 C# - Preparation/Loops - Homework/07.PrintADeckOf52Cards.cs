using System;

class Program
{
    static void Main(string[] args)
    {
        string card;

        for (int j = 2; j <= 14; j++)
        {
            for (int k = 0; k < 1; k++)
            {
                switch (j)
                {
                    case 11:
                        card = "J";
                        break;
                    case 12:
                        card = "Q";
                        break;
                    case 13:
                        card = "K";
                        break;
                    case 14:
                        card = "A";
                        break;
                    default:
                        card = j.ToString();
                        break;
                }
                Console.WriteLine($"{card} of spades, {card} of clubs, {card} of hearts, {card} of diamonds");
            }
        }
    }
}