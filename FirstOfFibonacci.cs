using System;

class FirstOfFibonacci
{
    static void Main()
    {
        Console.WriteLine("Write N =");
        int n = int.Parse(Console.ReadLine());
        int first = 0;
        int second = 1;

        for (int i = 2; i < n; i++)
        {
            int tmp = first;
            first = second;
            second = second + tmp;
        }

        Console.WriteLine("Number N of Fibonacci = " + second);

    }
}

