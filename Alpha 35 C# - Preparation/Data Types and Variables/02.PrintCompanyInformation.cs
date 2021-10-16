using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string website = Console.ReadLine();
        Console.Write("Manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string age = Console.ReadLine();
        Console.Write("Manager phone: ");
        string managerPhoneNumber = Console.ReadLine();

        if (faxNumber == string.Empty)
        {
            faxNumber = "(no fax)";
        }

        Console.WriteLine($"{companyName}\r\n" +
            $"Address: {companyAddress}\r\n" +
            $"Tel. {phoneNumber}\r\n" +
            $"Fax: {faxNumber}\r\n" +
            $"Web site: {website}\r\n" +
            $"Manager {firstName} {lastName} (age: {age}, tel. {managerPhoneNumber})\r\n");
    }
}