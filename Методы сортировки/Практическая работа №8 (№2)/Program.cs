using System;

namespace Практическая_работа__8___2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Random rand = new Random();
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] m1 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m1[i, j] = rand.Next(10);
                    Console.Write("{0,9} ", m1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int k = 0;k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j  < n; j++)
                    {
                        if (m1[k, i] > m1[k, j] & i > k)
                        {
                            temp = m1[k, i];
                            m1[k, i] = m1[k, j];
                            m1[k, j] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,9} ", m1[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}