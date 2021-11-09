using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < n; j++)
        {
            arr2[j] = int.Parse(Console.ReadLine());
        }

        bool isEqual = Enumerable.SequenceEqual(arr1, arr2);

        if (isEqual)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}