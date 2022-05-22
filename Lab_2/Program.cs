using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector();
            Matrix();
            Console.ReadLine();
        }
        static void Vector()
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var a = new double[n];
            var b = new double[n];
            Random rand = new Random(n);
            for (int i = 0; i < n; i++)
            {
                a[i] = rand.NextDouble() * 21 - 11;
                b[i] = rand.NextDouble() * 21 - 11;
            }
            Console.Write("a = ");
            foreach (int i in a)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("b = ");
            foreach (int i in b)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            var d = new double[n];
            for (int i = 0; i < n; ++i)
                d[i] = a[i] - (2 * b[i]);
            double c = 0; 
            for (int i = 0; i < n; ++i)
                c += d[i] * a[i];
            Console.WriteLine("c = {0:f2}", c);
        }
        static void Matrix()
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            var m = int.Parse(Console.ReadLine());
            int[,] mat = new int[m, n];
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = rand.Next(-50, 50);
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int negative = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                        negative++;
                }
            }
            Console.WriteLine("Кількість від'ємних елементів: " + negative);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == mat[1, j])
                        mat[1, j] = Convert.ToInt32(Math.Cos(Math.Pow(i, 2) + Math.Pow(j, 2) / n));
                    else
                        if (mat[i, j] == mat[i, n - 1])
                        mat[i, n - 1] = Convert.ToInt32(Math.Cos(Math.Pow(i, 2) + Math.Pow(j, 2) / n));
                    else
                        mat[i, j] = (mat[i, n - 1] + mat[m - 1, j]) / 2;    
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}