using System;

class CalculatesTheSum
{
    static double Fact(int n)
    {
        if (n == 1)
            return 1;
        else
            return n * Fact(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Write N =");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Write X =");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + Fact(i) / (Math.Pow(x, i));
        }

        Console.WriteLine("Sum = " + sum);
    }
}

