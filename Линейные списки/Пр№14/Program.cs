using System;

namespace Пр_14
{

    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList Station = new SingleLinkedList();
            string a;
            int b;
            int k = 0;
            while (k != 6)
            {
                Console.Clear();
                Console.WriteLine("Доступные команды:");
                Console.WriteLine("1 - Создание новой записи");
                Console.WriteLine("2 - Просмотр всех данных");
                Console.WriteLine("3 - Просмотр данных об абоненте по номеру телефона");
                Console.WriteLine("4 - Вставка записи после другой записи");
                Console.WriteLine("5 - Удаление первой записи");
                Console.WriteLine("6 - Выход");
                k = Convert.ToInt32(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Введите данных об абоненте в след. порядке: ");
                        Console.Write("Фамилия Имя Отчество ");
                        Console.Write("Номер телефона ");
                        Console.Write("Адрес ");
                        Console.Write("Тариф: ");
                        string info = Console.ReadLine();
                        string[] inf = info.Split();
                        Station.AddElement(inf[0], inf[1], inf[2], inf[3], inf[4], inf[5]);
                        Console.WriteLine("Нажмите Enter для продолжения...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Station.Print();
                        Console.WriteLine("Нажмите Enter для продолжения...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Введите номер телефона: ");
                        a = Console.ReadLine();
                        Station.NomerInf(a);
                        Console.WriteLine("Нажмите Enter для продолжения...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Введите номер элемента, после которого вы хотите добавить новую запись: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите данных об абоненте в след. порядке: ");
                        Console.Write("Фамилия Имя Отчество ");
                        Console.Write("Номер телефона ");
                        Console.Write("Адрес ");
                        Console.Write("Тариф: ");
                        string add = Console.ReadLine();
                        string[] i = add.Split();
                        Station.AddAfter(i[0], i[1], i[2], i[3], i[4], i[5], b);
                        Console.WriteLine("Нажмите Enter для продолжения...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Station.Delete();
                        Console.WriteLine("Первый элемент удалён");
                        Console.WriteLine("Нажмите Enter для продолжения...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        if (k != 6)
                        {
                            Console.WriteLine("Введена неверная команда");
                        }
                        k = 6;
                        break;
                }
            }
        }
    }
    public class Node
    {
        public string lastname;
        public string firstname;
        public string middlename;
        public string nomer;
        public string addres;
        public string tarif;
        private Node link;
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }
        public string Nomer
        {
            get { return nomer; }
            set { nomer = value; }
        }
        public string Addres
        {
            get { return addres; }
            set { addres = value; }
        }
        public string Tarif
        {
            get { return tarif; }
            set { tarif = value; }
        }
        public Node Link
        {
            get { return link; }
            set { link = value; }
        }

        public Node() { }
        public Node(string lastname, string firstname, string middlename, string nomer, string addres, string tarif)
        {
            lastname = Lastname;
            firstname = Firstname;
            middlename = Middlename;
            nomer = Nomer;
            addres = Addres;
            tarif = Tarif;
        }
        public Node(string lastname, string firstname, string middlename, string nomer, string addres, string tarif, Node link)
        {
            Lastname = lastname;
            Firstname = firstname;
            Middlename = middlename;
            Nomer = nomer;
            Addres = addres;
            Tarif = tarif;
            Link = link;
        }
    }

    public class SingleLinkedList
    {
        private Node FIRST;
        private Node LAST;
        public Node first
        {
            get { return FIRST; }
            set { FIRST = value; }
        }
        public Node last
        {
            get { return LAST; }
            set { LAST = value; }
        }
        public SingleLinkedList()
        {
            first = null;
        }
        public SingleLinkedList(string lastname, string firstname, string middlename, string nomer, string addres, string tarif)
        {
            Node p = new Node(lastname, firstname, middlename, nomer, addres, tarif);
            if (first == null)
            {
                first = p;
            }
            else
            {
                LAST.Link = p;
                LAST = p;
            }
        }
        public void AddElement(string lastname, string firstname, string middlename, string nomer, string addres, string tarif)
        {
            Node p = new Node(lastname, firstname, middlename, nomer, addres, tarif);
            p.lastname = lastname;
            p.firstname = firstname;
            p.middlename = middlename;
            p.nomer = nomer;
            p.addres = addres;
            p.tarif = tarif;
            if (first == null)
            {
                first = p;
                first.Link = null;
                last = first;
            }
            else
            {
                last.Link = p;
                last = p;
            }
        }
        public void AddAfter(string lastname, string firstname, string middlename, string nomer, string addres, string tarif, int node)
        {
            Node p = new Node(lastname, firstname, middlename, nomer, addres, tarif);
            int cnt = 0;
            p.lastname = lastname;
            p.firstname = firstname;
            p.middlename = middlename;
            p.nomer = nomer;
            p.addres = addres;
            p.tarif = tarif;
            Node temp;
            Node c = first;
            while (c != null)
            {
                c = c.Link;
                cnt++;
            }
            c = first;
            if (first == null)
            {
                first = p;
                first.Link = null;
                last = first;
            }
            else
            {
                if (node < cnt)
                {
                    for (int i = 0; i < node - 1; i++)
                    {
                        c = c.Link;
                    }
                    temp = c.Link;
                    c.Link = p;
                    p.Link = temp;
                }
                else
                {
                    last.Link = p;
                    last = p;
                }
            }
        }

        public void Print()
        {
            Node p = first;
            int cnt = 0;
            while (p != null)
            {
                cnt++;
                Console.WriteLine(cnt + ". " + p.lastname + " " + p.firstname + " " + p.middlename + " " + p.nomer + " " + p.addres + " " + p.tarif);
                p = p.Link;
            }
        }
        public void NomerInf(string a)
        {
            Node p = first;
            int cnt = 0;
            while (p != null)
            {
                cnt++;
                if (a == p.nomer)
                {
                    Console.WriteLine(cnt + ". " + p.lastname + " " + p.firstname + " " + p.middlename + " " + p.nomer + " " + p.addres + " " + p.tarif);
                }
                p = p.Link;
            }
        }
        public void Delete()
        {
            Node p = first;
            Node c = p.Link;
            if (p != null)
            {
                c.Link = null;
                first = c;
            }
        }


    }

}
