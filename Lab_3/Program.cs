using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polygon[] points = { new Polygon(3, 4), new Polygon(6, 3), new Polygon(10, 5), new Polygon(8, 7) };

        }
        class Polygon
        {
            protected double x;
            protected double y;

            public double X
            {
                set { x = value; }
                get { return x; }
            }
            public double Y
            {
                set { y = value; }
                get { return y; }
            }
            public Polygon(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public Polygon()
            {
            }
            public Polygon factory(params int[] numbers)
            {
                if ((numbers.Length >= 6) && (numbers.Length % 2 == 0))
                {
                    Polygon mn = new Polygon();
                    return mn;
                }
                else
                    return null;
            }
            public Polygon factory(params Polygon[] points)
            {
                if (points.Length >= 3)
                {
                    Polygon mn = new Polygon();
                    mn.Polygon = Polygon;
                    return mn;
                }
                else
                    return null;
            }
            public double Perimeter_points()
            {
                double P = 0;
                int i = 0;
                int j = 1;

                for (i = 0; i < Polygon.Length; i++)
                {
                    P += Math.Sqrt(Math.Pow((Polygon[i].X - Polygon[j].X), 2) +
                                   Math.Pow((points[i].Y - points[j].Y), 2));
                    j++;
                    if (j == points.Length)
                        j = 0;
                }
                return P;
            }

        }
  