using System;

namespace Практическая_работа__7__Задание__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Введите N: ");
            N = int.Parse(Console.ReadLine());
            int[,] A = new int[N, N];
            for (int i = 0; i < A.GetLength(0); ++i)
            {
                for (int j = 0; j < A.GetLength(1); ++j)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < A.GetLength(0); ++i)
            {
                for (int j = 0; j < A.GetLength(1); ++j)
                {
                    Console.Write("\t" + A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] > 0)
                    {
                        A[i, j] = 1;
                    }
                    else
                    {
                        A[i, j] = 0;
                    }
                    if (j <= i) { Console.Write("{0}\t", A[i, j]); }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
