using System;
using System.Runtime.ExceptionServices;

namespace Практическая_работа__10
{

    class Program
    {
        static void Main(string[] args)
        {
            string h = null;
            int k = 0;
            int b = 0;
            while (k != 4)
            {
                Console.Clear();
                Console.WriteLine("Выберете пункт меню:");
                Console.WriteLine("1 - Ввод данных");
                Console.WriteLine("2 - Просмотр данных");
                Console.WriteLine("3 - Обработка");
                Console.WriteLine("4 - Выход");
                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        h = first(h);
                        b = first2(b);
                        break;
                    case 2:
                        two(h, b);
                        break;
                    case 3:
                        Tre(h, b);
                        break;
                    default:
                        if (k != 4)
                            Console.WriteLine("Введена неверная команда");
                        k = 4;
                        break;
                }
            }
        }
        static string first(string h)
        {
            Console.Clear();
            Console.WriteLine("Введите строку слов, разделённых пробелами");
            h = Console.ReadLine();
            return h;
        }
        static int first2(int b)
        {
            Console.WriteLine("Введите номер слова, которому хотите навредить");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadLine();
            Console.Clear();
            return b;
        }
        static void two(string h, int b)
        {
            Console.Clear();
            Console.WriteLine("Сейчас занесена строка:");
            Console.WriteLine(h);
            Console.Write("Магия будет происходить со словом под номером:");
            Console.WriteLine(b);
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadLine();
            Console.Clear();
        }
        static void Tre(string rab, int b)
        {
            int m;
            Console.Clear();
            string[] s1 = rab.Split(' ');
            m = s1[b].Length;
            if (b - 1 < s1.Length)
                for (int i = 0; i < s1.Length; i++)
                {
                    if (m == s1[i].Length)
                    {
                        Console.Write(s1[i] + " ");
                    }
                }
            else
                Console.Write("Номер слова которое вы выбрали, далеко впереди.. или сзади.");
            Console.WriteLine();
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadLine();
            Console.Clear();
        }
    }
}