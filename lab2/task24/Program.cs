using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task24
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
            String r;
            r = Console.ReadLine();
            double w;
            w = double.Parse(r);
            double b;
            b = a * ((c * v) /( w * w));
            Console.WriteLine("{0:F4}", b);
        }
    }
}
