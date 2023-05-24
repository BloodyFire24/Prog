using System;
using System.IO;

namespace Практическая_работа__11__Задание__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            string text;
            string[] words;
            string[] haschar = new string[100];
            string path;
            string fullpath;
            Console.WriteLine("Введите символ");
            a = Convert.ToChar(Console.ReadLine());
            path = @"txt\1.txt";
            fullpath = Path.GetFullPath(path);
            text = File.ReadAllText(fullpath);
            words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (words[i][j] == a)
                    {
                        Console.WriteLine(words[i] + "\t" + "Первый встречающийся символ найден на позиции: " + (j + 1));
                        break;
                    }
                }
            }
        }
    }
}