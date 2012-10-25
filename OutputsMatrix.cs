using System;

class OutputsMatrix
{
    static void Main()
    {
        Console.WriteLine("Write N =");
        int n = int.Parse(Console.ReadLine());

        if (n >= 20) 
        {
            Console.WriteLine("N must be < 20");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i + j + " ");
            }
            Console.WriteLine();
        }
    }
}

