using System;
using System.IO;

namespace Практическая_работа__13
{
    class Program
    {
        public static int p = 1;
        public static int c = 0;
        static void Main()
        {
            string path1 = @"bd\1.txt";
            string file1 = Path.GetFullPath(path1);
            int j = 1;
            int k;
            while (j != 0)
            {
                k = 1;
                while (k != 0)
                {
                    Console.Clear();
                    Console.WriteLine("Доступные команды");
                    Console.WriteLine("0 - Выход");
                    Console.WriteLine("1 - Добавление записей");
                    Console.WriteLine("2 - Просмотр записей");
                    try
                    {
                        j = Convert.ToInt32(Console.ReadLine());
                        k = 0;
                    }
                    catch
                    {
                        Console.WriteLine("Введена неизвестная команда");
                        Console.WriteLine("Введите Enter для продолжения...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                switch (j)
                {
                    case 1:
                        Console.Clear();
                        Dobav(file1);
                        break;
                    case 2:
                        Console.Clear();
                        Prosm(file1);
                        break;
                    default:
                        if (j != 0)
                        Console.WriteLine("Введена неизвестная команда");
                        Console.WriteLine("Введите Enter для продолжения...");
                        Console.ReadLine();
                        break;
                }
            }
        }
        static void Dobav(string file1)
        {
            string info;
            Console.WriteLine("Введите ФИО, номер телефона, адрес и тариф абонента");
            info = Console.ReadLine();
            FileStream fs = new FileStream(file1, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(info);
            sw.Close();
            Console.Clear();
            Console.WriteLine("Введите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();
        }

        static void Prosm(string file1)
        {

            int k = 20;
            while (k != 0)
            {
                Console.Clear();
                int n = File.ReadAllLines(file1).Length;
                Console.WriteLine("Доступные команды");
                Console.WriteLine("1 - Просмотр всех записей");
                Console.WriteLine("2 - Просмотр записей с определённым тарифом");
                Console.WriteLine("3 - Выход");
                Person[] persons = new Person[n];
                string[] lines = File.ReadAllLines(file1);
                string[] x;
                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.Clear();
                        for (int i = 0; i < n; i++)
                        {
                            x = lines[i].Split(' ');
                            persons[i].lastname = x[0];
                            persons[i].firstname = x[1];
                            persons[i].middlename = x[2];
                            persons[i].nomer = x[3];
                            persons[i].adress = x[4];
                            persons[i].tarif = x[5];
                            persons[i].Print();
                            Console.WriteLine();
                        }
                        Console.WriteLine("Введите Enter для продолжения...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        for (int i = 0; i < n; i++)
                        {
                            x = lines[i].Split(' ');
                            persons[i].lastname = x[0];
                            persons[i].firstname = x[1];
                            persons[i].middlename = x[2];
                            persons[i].nomer = x[3];
                            persons[i].adress = x[4];
                            persons[i].tarif = x[5];
                        }
                        Console.WriteLine("Введите название тарифа, список поьзователей которого вы хотите просмотреть:");
                        string s = Console.ReadLine();
                        Console.WriteLine();
                        for (int i = 0; i < n; i++)
                        {
                            if (persons[i].tarif == s)
                            {
                                persons[i].Print();
                                Console.WriteLine();
                            }

                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        k = 0;
                        break;
                    default:
                        Console.WriteLine("Введена неизвестная команда");
                        Console.WriteLine("Введите Enter для продолжения...");
                        Console.ReadLine();
                        k = 0;
                        break;
                }
                Console.WriteLine("Введите Enter для продолжения...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
    public struct Person
    {
        public string lastname;
        public string firstname;
        public string middlename;
        public string nomer;
        public string adress;
        public string tarif;
        public void Print()
        {

            Console.WriteLine($"Фамилия: {lastname}");
            Console.WriteLine($"Имя: {firstname}");
            Console.WriteLine($"Отчество: {middlename}");
            Console.WriteLine($"Номер телефона: {nomer}");
            Console.WriteLine($"Адрес: {adress}");
            Console.WriteLine($"Тариф: {tarif}");
            Console.WriteLine();
        }
    }
}
