using System;
using System.Globalization;
using System.Threading;

class Nums
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine("{0:F3}", (i * i));
            }
            else
            {
                Console.WriteLine("{0:F3}", Math.Sqrt(i));
            }
        }
    }
}
