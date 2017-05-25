using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task33_
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            String x;
            x = Console.ReadLine();
            double z;
            z = double.Parse(x);
            double b;
            b = Math.Sin(a) * Math.Cos(z) + Math.Cos(a) * Math.Sin(z);
            Console.WriteLine("{0:F4}", b);
        }
    }
}
