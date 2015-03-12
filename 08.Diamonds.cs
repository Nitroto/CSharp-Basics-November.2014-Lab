using System;
using System.Globalization;
using System.Threading;

class Diamonds
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int spacesBefore = n / 2;
        int spacesMiddle = 1;
        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                Console.Write(new string('-', spacesBefore));
                Console.Write('*');
                Console.Write(new string('-', spacesBefore));
                Console.WriteLine();
                spacesBefore--;
            }
            else if (i < n / 2)
            {
                Console.Write(new string('-', spacesBefore));
                Console.Write('*');
                Console.Write(new string('-', spacesMiddle));
                Console.Write('*');
                Console.Write(new string('-', spacesBefore));
                Console.WriteLine();
                spacesBefore--;
                spacesMiddle += 2;
            }
            else
            {
                Console.Write(new string('-', spacesBefore));
                Console.Write('*');
                Console.Write(new string('-', spacesMiddle));
                Console.Write('*');
                Console.Write(new string('-', spacesBefore));
                Console.WriteLine();
                spacesBefore++;
                spacesMiddle -= 2;
            }
        }
    }
}
