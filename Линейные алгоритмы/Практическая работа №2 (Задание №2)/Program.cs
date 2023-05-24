using System;

namespace Практическая_работа__2__Задание__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчёта суммы денег");
            int k;
            int p;
            int s;
            int n = 0;
            string l;
            Console.Write("Введите стартовый капитал:");
            l = Console.ReadLine();
            k = Convert.ToInt32(l);
            Console.Write("Введите процент увеличения капитала:");
            l = Console.ReadLine();
            p = Convert.ToInt32(l);
            Console.Write("Введите Сумму, необходимую для покупки магазина:");
            l = Console.ReadLine();
            s = Convert.ToInt32(l);
            do
            {
                n += 1;
                k += (k / 100) * p;
            }
            while (k < s);
            Console.WriteLine($"Коммерсанту потребуется {n} лет, чтобы купить свой магазин");
        }
    }
}
