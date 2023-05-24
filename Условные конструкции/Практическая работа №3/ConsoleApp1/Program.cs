using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            int a;
            int b;
            string l;
            Console.Write("Введите a:");
            l = Console.ReadLine();
            a = Convert.ToInt32(l);
            Console.Write("Введите b:");
            l = Console.ReadLine();
            b = Convert.ToInt32(l);
            if (a < b)
            {
                x = (b / a) - 1;
            }
            if (a==b)
            {
                x = -295;
            }
            if (a > b)
            {
                x = (a - 235) / b;
            }
            Console.WriteLine($"a:{a}, b:{b}, x:{x}");
        }
    }
}
