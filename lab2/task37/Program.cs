using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task37
{
    class Program
    {
        static void Main(string[] args)
        {
            String q;
            q = Console.ReadLine();
            double o;
            o = double.Parse(q);
            String k;
            k = Console.ReadLine();
            double w;
            w = double.Parse(k);
            double b;
            b = o + w;
            Console.WriteLine("{0:F4}", b);

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
            double z;
            z = ((a * s) + (f * d)) / (a * d);
            Console.WriteLine("{0:F4}", z);
        }
    }
}
