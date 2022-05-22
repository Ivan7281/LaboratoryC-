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
            var c1 = new TCircle(6);
            var c2 = new TCircle(4);
            var c3 = new TCircle();
            c3.InputRadius();
            Console.WriteLine(c1.SCircle());
            Console.WriteLine(c1.CCircle());
            c3 = c1 * 2 + c2;
            c3.ReturnRadius();
            Console.ReadLine();
        }
    }
    class TCircle
    {
        public double r;
        public TCircle()
        {
            r = 1;
        }
        public TCircle(double r)
        {
            this.r = r;
        }
        public TCircle(TCircle c)
        {
            r = c.r;
        }
        public void InputRadius()
        {
            Console.WriteLine("Ввести радіус: ");
            r = double.Parse(Console.ReadLine());
        }
        public void ReturnRadius()
        {
            Console.WriteLine("Радіус: {0}", r);
        }
        public double SCircle()
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public double CCircle()
        {
            return 2 * Math.PI * r;
        }
        public bool Equal(TCircle p)
        {
            return p.r == r;
        }
        public static TCircle operator +(TCircle p1, TCircle p2)
        {
            return new TCircle(p1.r + p2.r);
        }
        public static TCircle operator -(TCircle p1, TCircle p2)
        {
            return new TCircle(-p1.r - p2.r);
        }
        public static TCircle operator *(TCircle p1, double n)
        {
            return new TCircle(n * p1.r);
        }
    }
}
