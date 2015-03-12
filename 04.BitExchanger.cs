using System;
using System.Globalization;
using System.Threading;

class BitExchanger
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long n = long.Parse(Console.ReadLine());
        long bit24 = n >> 24 & 1;
        long bit3 = n >> 3 & 1;
        if (bit24!=bit3)
        {
            if (bit24 == 1 && bit3 == 0)
            {
                n |= (1 << 3);
                n &= ~(1 << 24);
            }
            else
            {
                n &= ~(1 << 3);
                n |= (1 << 24);
            }
        }
        Console.WriteLine(n);
    }
}
