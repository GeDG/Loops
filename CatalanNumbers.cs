using System;

class CatalanNumbers
{
    static double Fact(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Fact(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Write N =");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("N must be >= 0");
            return;
        }

        Console.WriteLine((Fact(2*n))/((Fact(n+1))*Fact(n)));

    }
}

