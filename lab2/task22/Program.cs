using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
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
            double x;
            x = double.Parse(z);
            double b;
            b =  (a * 9.8067) * Math.Cos(x);
            Console.WriteLine("{0:F4}", b);
        }
    }
}
