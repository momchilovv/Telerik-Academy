using System;

class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            Console.Write($"{i} ");
   
            for (int j = 1; j < input; j++)
            {
                Console.Write($"{j + i} ");
                
            }
            Console.WriteLine();
        }      
    }
}