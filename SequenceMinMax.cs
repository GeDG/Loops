using System;


class SequenceMinMax
{
    static void Main()
    {
        Console.WriteLine("Write N =");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (min > numbers[i]) 
            {
                min = numbers[i];
            }
            if (max < numbers[i])
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("Max = "+max);
        Console.WriteLine("Min = "+min);

    }
}

