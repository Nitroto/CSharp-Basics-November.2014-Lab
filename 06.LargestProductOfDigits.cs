using System;
using System.Globalization;
using System.Threading;

class LargestProductOfDigits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string numbers = Console.ReadLine();
        int largestProduct = int.MinValue;
        for (int i = 0; i < numbers.Length-5; i++)
        {
            int currentProduct = (numbers[i] - '0') * (numbers[i + 1] - '0') * (numbers[i + 2] - '0') * (numbers[i + 3] - '0') * (numbers[i + 4] - '0') * (numbers[i + 5] - '0');
            largestProduct = Math.Max(largestProduct, currentProduct);
        }
        Console.WriteLine(largestProduct);
    }
}
