using System;

class Program
{
    static void Main()
    {
        double deposit = double.Parse(Console.ReadLine());

        double firstYearInterest = deposit + (deposit * 0.05);
        double secondYearInterest = firstYearInterest + (firstYearInterest * 0.05);
        double thirdYearInterest = secondYearInterest + (secondYearInterest * 0.05);

        Console.WriteLine(String.Format("{0:0.00}", firstYearInterest));
        Console.WriteLine(String.Format("{0:0.00}", secondYearInterest));
        Console.WriteLine(String.Format("{0:0.00}", thirdYearInterest));
    }
}