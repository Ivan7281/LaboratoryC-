using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TSMatrix m1 = new TSMatrix(3);
            //m1.InputN();
            m1.Matrix();
            Console.Write("Найбільший елемент: ");
            m1.MaxЕlement();
            Console.Write("Найменший елемент: ");
            m1.MinЕlement();
            Console.Write("Сума елемент: ");
            m1.SumMatrix();
            Console.ReadLine();
        }
    }
    class TSMatrix
    {
        public int n;
        int[,] mass;
        public TSMatrix(int n)
        {
            this.n = n;
            mass = new int[this.n, this.n];
        }
        public TSMatrix(TSMatrix r)
        {
            this.n = r.n;
            this.mass = r.mass;
        }
        public void Matrix()
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rand.Next(-50, 50);
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void MaxЕlement()
        {
            int element = mass[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mass[i, j] > element)
                    {
                        element = mass[i, j];
                    }
                }
            }
            Console.WriteLine(element);
        }
        public void MinЕlement()
        {
            int element = mass[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mass[i, j] < element)
                    {
                        element = mass[i, j];
                    }
                }
            }
            Console.WriteLine(element);
        }
        public void SumMatrix()
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += mass[i, j];
                }
            }
            Console.WriteLine(sum);
        }
        public static TSMatrix operator +(TSMatrix m1, TSMatrix m2)
        {
            int[,] result = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                }
            }
        }
    }
}
