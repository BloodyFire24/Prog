using System;

namespace Практическая_работа__12
{
    class Program
    {
        static void Main(string[] args)
        {
            mat n = new mat(4);
            n.WriteMat();
            n.ReadMat();
            n.Move();
            Console.WriteLine();
            n.ReadMat();
        }
    }

    class mat
    {
        public int n, i, j, x;
        public int[,] mass;
        public mat() { }

        public int N
        {
            get { return n; }
            set { if (value > 0) n = value; }
        }

        public mat(int n)
        {
            this.n = n;
            mass = new int[this.n, this.n];
        }

        public int this[int i, int j]
        {
            get
            {
                return mass[i, j];
            }
            set
            {
                mass[i, j] = value;
            }
        }

        public void WriteMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите элемент матрицы {0}:{1}", i+1, j+1);
                    mass[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void ReadMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void Move()
        {
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int temp = mass[i, j];
                    mass[i, j] = mass[n - 1 - i, j];
                    mass[n - 1 - i, j] = temp;
                }
            }
        }
    }
}
