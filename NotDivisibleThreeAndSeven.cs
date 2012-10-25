using System;

class NotDivisibleThreeAndSeven
{
    static void Main()
    {
        Console.WriteLine("Write N =");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 != 0 || i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}

