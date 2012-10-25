using System;


class GreatestCommonDivisor
{
    static void Main()
    {
        Console.WriteLine("Write first =");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Write second =");
        int b = int.Parse(Console.ReadLine());

        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        if (a == 0)
            Console.WriteLine(b);
        else
            Console.WriteLine(a);

    }
}

