using System;

class FactDividedFact
{
    static double Fact(int n) 
    {
        if (n == 1)
            return 1;
        else
            return n*Fact(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Write N =");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Write K =");
        int k = int.Parse(Console.ReadLine());

        if (n > k) 
        {
            Console.WriteLine("K must be > N");
            return;
        }
        if (n <= 1)     
        {
            Console.WriteLine("N must be > 1");
            return;
        }

        Console.WriteLine(Fact(n)/Fact(k));

    }
}

