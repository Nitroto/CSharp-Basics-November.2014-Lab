using System;
using System.Globalization;
using System.Threading;

class BitSequenceExchange
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long n = long.Parse(Console.ReadLine());
        long firstPart = (n >> 3) & ((1 << 3) - 1);
        long secondPart = (n >> 24) & (((1 << 3) - 1));
        long mask = 0;
        mask = ((1 << 3) - 1) << 3;
        mask |= ((1 << 3) - 1) << 24;
        n &= ~mask;
        n |= firstPart << 24;
        n |= secondPart << 3;
        Console.WriteLine(n);
    }
}
