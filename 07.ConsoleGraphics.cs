using System;
using System.Globalization;
using System.Threading;

class ConsoleGraphics
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int bridge = n / 2 + 1;
        int spaces = 2 * n - 2 * bridge;
        Console.WriteLine(new string('*',2*n));
        Console.WriteLine(new string('*', 2*n));
        for (int i = 0; i < n - 1;i++)
        {
            Console.Write(new string('*', bridge));
            Console.Write(new string(' ', spaces));
            Console.Write(new string('*', bridge));
            Console.WriteLine();
        }
        Console.WriteLine(new string('~', 2 * n));
        Console.WriteLine(new string('~', 2 * n));
    }
}
