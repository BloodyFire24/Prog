using System;

namespace Практическая_работа__5__Задание__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int i = 0;
            Console.WriteLine("Введите a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a <= b)
            {
                do
                {
                    if (a % 7 == 0 && a < 0)
                    {
                        Console.WriteLine(a);
                    }
                    a++;
                    i++;
                }
                while (i < b);
            }
        }
    }
}
