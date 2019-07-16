using System;

namespace aray1
{
    class Program
    {
        static void Main(string[] args)
        {
          
                int m = 2, n = 2, p = 2, q = 2, i, j;
                int[,] a = { { 1, 4 }, { 2, 5} };
                int[,] b = { { 3, 4}, { 3, 5 } };
                Console.WriteLine("Matrix a:");

            for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Matrix b:");
                for (i = 0; i < p; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        Console.Write(b[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                if (n != p)
                {
                    Console.WriteLine("No matrix multiply doable");
                }
                else
                {
                    int[,] c = new int[m, q];
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < q; j++)
                        {
                            c[i, j] = 0;
                            for (int k = 0; k < n; k++)
                            {
                                c[i, j] += a[i, k] * b[k, j];
                            }
                        }
                    }
                    Console.WriteLine("The product of the two matrices is :");
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write(c[i, j] + "\t");
                        }
                        Console.WriteLine();
                  
          }
    }

}
    }
}
