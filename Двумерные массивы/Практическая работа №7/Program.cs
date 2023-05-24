using System;

namespace Практическая_работа__7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int M;
            Console.WriteLine("Введите M");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите N");
            N = int.Parse(Console.ReadLine());
            int[,] m = new int[M, N];
            Console.WriteLine("Заполнение матрицы");
            for (int i = 0; i < m.GetLength(0); ++i)
            {
                for (int j = 0; j < m.GetLength(1); ++j)
                {
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < m.GetLength(0); ++i)
            {
                for (int j = 0; j < m.GetLength(1); ++j)
                {
                    Console.Write("\t" + m[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
