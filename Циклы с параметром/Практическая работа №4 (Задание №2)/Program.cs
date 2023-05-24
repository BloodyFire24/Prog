using System;

namespace Практическая_работа__4__Задание__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int k;
            int b = 0;
            string l;
            Console.WriteLine("Введите норму высоты, которую необходимо выполнить:");
            l = Console.ReadLine();
            k = Convert.ToInt32(l);
            Console.WriteLine("Введите высоту, на которую прыгнул спортсмен:");
            for (int i =1; i <= 20; i++)
            {
                l = Console.ReadLine();
                a = Convert.ToInt32(l);
                if (a >= k)
                {
                    b++;
                }
            }
            Console.WriteLine($"Норму выполнили {b} спортсменов");
        }
    }
}
