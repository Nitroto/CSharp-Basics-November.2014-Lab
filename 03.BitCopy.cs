using System;
using System.Globalization;
using System.Threading;

class BitCopy
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int bit = n >> p & 1;
        if (bit == 1)
        {
            n |= 1 << 2;
        }
        else
        {
            n &= ~(1 << 2);
        }
        Console.WriteLine(n);
    }
}
