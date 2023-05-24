using System;

namespace Практическая_работа__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчёта пути.");
            int v;
            int u;
            int t1;
            int t2;
            int s;
            string l;
            Console.Write("Введите скорость лодки в стоячей воде:");
            l = Console.ReadLine();
            v = Convert.ToInt32(l);
            Console.Write("Введите скорость течения реки:");
            l = Console.ReadLine();
            u = Convert.ToInt32(l);
            Console.Write("Введите время движения лодки по озеру:");
            l = Console.ReadLine();
            t1 = Convert.ToInt32(l);
            Console.Write("Введите время движения лодки по течению:");
            l = Console.ReadLine();
            t2 = Convert.ToInt32(l);
            s = v * t1 + (v - u) * t2;
            Console.WriteLine("Путь:" + s);
        }
    }
}
