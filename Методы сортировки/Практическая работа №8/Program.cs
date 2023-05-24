using System;

namespace Практическая_работа__8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сортировка массива и двоичный поиск. Что нужно сделать?");
            Console.WriteLine("1 - Сортировка вставкой");
            Console.WriteLine("2 - Сортировка выбором");
            Console.WriteLine("3 - Сортировка обменом");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine()); 
            int[] m1 = new int[n];
            for(int i = 0; i < n; i++)
            {
                m1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write("{0,9} ", m1[i]);
            }
            Console.WriteLine();
            if (a == 1)
            {
                int cur;
                int j;
                int i;
                for (i = 0; i < n; i++)
                {
                    cur = m1[i];
                    j = i;
                    while ((j > 0) && (cur < m1[j - 1]))
                    {
                        m1[j] = m1[j - 1];
                        j--;
                    }
                    m1[j] = cur;
                }
            }
            if(a ==2)
            {
                int index;
                for (int i = 0; i < n; i++) 
                {
                    index = i; 
                    for (int j = i; j < n; j++) 
                    {
                        if (m1[j] < m1[index])
                        {
                            index = j;               
                        }
                    }
                    if (m1[index] == m1[i])  
                        continue;
                    int temp = m1[i];
                    m1[i] = m1[index];
                    m1[index] = temp;
                }

            }
            if(a == 3)
            {
                int temp;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (m1[i] > m1[j])
                        {
                            temp = m1[i];
                            m1[i] = m1[j];
                            m1[j] = temp;
                        }
                    }
                }

            }
            if (a != 1 & a != 2 & a != 3)
            {
                Console.WriteLine("Массив не был отсортирован");
            }
            else
            {
                for (int mmm = 0; mmm < n; mmm++)
                {
                    Console.Write("{0,9} ", m1[mmm]);
                }
                Console.WriteLine();
                Console.WriteLine("Двоичный поиск");
                Console.WriteLine("Введите искомую переменную");
                int b = Convert.ToInt32(Console.ReadLine());
                int L = 0;
                int R = n - 1;
                int k = (R + L) / 2;
                int F = 0;
                while (L <= R)
                {
                    k = (R + L) / 2;
                    if (m1[k] == b)
                    {
                        Console.WriteLine("Элемент найден на позиции: " + k);
                        F = 1;
                        break;
                    }
                    else
                  if (m1[k] < b)
                        L = k + 1;
                    else
                        R = k - 1;
                }
                if (F == 0)
                {
                    Console.WriteLine("Элемент не найден");
                }
            }

        }
    }
}
