using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task36
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            String y;
            y = Console.ReadLine();
            double s;
            s = double.Parse(y);
            String u;
            u = Console.ReadLine();
            double d;
            d = double.Parse(u);
            String i;
            i = Console.ReadLine();
            double f;
            f = double.Parse(i);
            double b;
            b = Math.Sqrt((d - a) * (d - a) - (f - s) * (f - s));
            Console.WriteLine("{0:F4}", b);
        }
    }
}
