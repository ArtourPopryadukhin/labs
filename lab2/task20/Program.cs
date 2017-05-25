using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task20
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            String z;
            z = Console.ReadLine();
            double c;
            c = double.Parse(z);
            String x;
            x = Console.ReadLine();
            double v;
            v = double.Parse(x);
            double b;
            b = a * c * c / 2;
            Console.WriteLine("{0:F4}", b);
            
            String q;
            q = Console.ReadLine();
            double o;
            o = double.Parse(q);
            String d;
            d = Console.ReadLine();
            double s;
            s = double.Parse(d);
            double r;
            r = o * 9.8067 * s;
            Console.WriteLine("{0:F4}", r);
        }
    }
}
