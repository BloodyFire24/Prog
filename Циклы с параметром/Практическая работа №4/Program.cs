using System;

namespace Практическая_работа__4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double a = 1;
            string l;
            Console.WriteLine("Введите N>0:");
            l = Console.ReadLine();
            N = Convert.ToInt32(l);
            for (int i = 1; i <= N; i++)
            {
                a = a * (1 + 0.1 * i);
            }
            Console.WriteLine("Произведение N сомножителей:" + a);
        }
    }
}
