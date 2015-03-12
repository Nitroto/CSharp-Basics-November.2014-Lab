using System;
using System.Globalization;
using System.Threading;

class AccountInformation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        int id = int.Parse(Console.ReadLine());
        double balance = double.Parse(Console.ReadLine());
        string active = balance >= 0 ? "yes" : "no";
        Console.WriteLine("Hello, {0} {1}\r\nClient id: {2}\r\nTotal balance: {3:F2}\r\nActive: {4}", firstName,lastName,id,balance, active);
    }
}
