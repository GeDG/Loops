using System;

class HowManyZerosPresent
{

    static long Fact(int n)
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

        int count = 0;
        long number = Fact(n);

        while (true) 
        {
            if (number % 10 == 0)
            {
                count++;
                number = number / 10;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(count);
    }
}

