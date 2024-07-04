using System;

namespace HomeWork;

class Program
{
    static void Main()
    {
        int[,] a = {
                     { 7, 3, 2 },
                     { 4, 9, 6 },
                     { 1, 8, 5 }
                   };
        int y = a.GetLength(0);
        int x = a.GetLength(1);
        int[] sort = new int[x * y];
        int IndexSort = 0;
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                sort[IndexSort] = a[i, j];
                IndexSort++;
            }
        }
        Array.Sort(sort);
        IndexSort = 0;
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                a[i, j] = sort[IndexSort];
                IndexSort++;
                Console.Write($"{a[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
    