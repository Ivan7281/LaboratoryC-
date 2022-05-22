using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f = Minimal();
            Console.WriteLine(f);
            var c = WhileNumber();
            Console.WriteLine(c);
            Console.ReadLine();
        }
        static float Minimal()
        {
            var a = float.Parse(Console.ReadLine());
            var b = float.Parse(Console.ReadLine());
            var c = float.Parse(Console.ReadLine());
            float mini = 0;
            float k = a / b;
            float l = a / c;
            if (k < l)
            {
                mini += k;
            }
            else
            {
                mini += l;
            }
            float r = (a + b) / 2;
            float d = (b + c) / 2;
            if (r < d)
            {
                mini += r;
            }
            else
            {
                mini += d;
            }
            float g = c / (a + b);
            float o = b / (a + c);
            if (g < o)
            {
                mini += g;
            }
            else
            {
                mini += o;
            }
            return mini;

        }
        static int WhileNumber()
        {
            Console.WriteLine("numebr=");
            var number = int.Parse(Console.ReadLine());
            var number2 = number;
            var number3 = 0;
            var i = 1;
            var k = 0;
            var d = 0;
            var c = 0;
            var min = 10;
            while (d < 4)
            {
                k = number % 10;
                number = number / 10;
                if (d == 3)
                {
                    c = k;
                }
                if (k < min)
                {
                    min = k;
                }
                d += 1;
            }
            while (i <= 100)
            {
                k = number2 % 10;
                number2 = number2 / 10;
                if (i == 100)
                {
                    number3 += min * 1000;
                }
                if(min == k)
                {
                    number3 += c * i;
                }
                else
                {
                    number3 += k * i;
                }
                i *= 10;
            }
            return number3;
        }
    }
}
