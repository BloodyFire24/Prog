using System;
using System.IO;
using System.Linq;

namespace Практическая_работа__11__Задание__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"txt\1.txt";
            string fullpath = Path.GetFullPath(path);
            string matrixStr;
            string[] lines;
            string[] columns;
            int N;
            int M;
            double p;
            StreamReader streamreader = new StreamReader(fullpath);
            matrixStr = streamreader.ReadToEnd();
            lines = matrixStr.Split('\n');
            N = lines.Length;
            M = lines.First().Split(' ').Length;
            int[,] m = new int[N, M];
            double[] vector = new double[N];
            for (int i = 0; i < m.GetLength(0); i++)
            {
                columns = lines[i].Split(' ');
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = int.Parse(columns[j]);
                    Console.Write("\t" + m[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < m.GetLength(0); i++)
            {
                p = 0;
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    p += m[i, j];
                }
                p /= N;
                vector[i] = p;
            }
            Console.WriteLine("Вектор выглядит так:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }
    }
}
