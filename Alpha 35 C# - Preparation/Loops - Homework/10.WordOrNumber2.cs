using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<double> resultSum = new List<double>();
        List<string> strings = new List<string>();
        string input; 
        string result = "";

        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();

            if (double.TryParse(input, out double parsed))
            {
                resultSum.Add(double.Parse(input));
            }
            else
            {
                strings.Add(input);
            }
        }
        if (strings.Count == 0)
        {
            Console.WriteLine("no words");
            Console.WriteLine(resultSum.Sum());
        }
        else
        {
            foreach (var item in strings)
            {
                result += $"{item}-"; 
            }
            Console.WriteLine(result.Remove(result.Length - 1));
            Console.WriteLine(resultSum.Sum());
        }
    }
}