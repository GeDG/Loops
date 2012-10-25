using System;


class SpiralLooping
{
    static void Main()
    {
        Console.WriteLine("Write N =");
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        int[,] matrix = new int[n, n];
        int x = 0, y = 0;
        int size = n;

        while (size > 0)
        {
            for (int i = y; i <= y + size - 1; i++)
            {
                matrix[x, i] = number++;
            }

            for (int j = x + 1; j <= x + size - 1; j++)
            {
                matrix[j, y + size - 1] = number++;
            }

            for (int i = y + size - 2; i >= y; i--)
            {
                matrix[x + size - 1, i] = number++;
            }

            for (int i = x + size - 2; i >= x + 1; i--)
            {
                matrix[i, y] = number++;
            }

            x++;
            y++;
            size -= 2;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j]);
                Console.Write("    ");
            }
            Console.WriteLine();
        }

    }
}

