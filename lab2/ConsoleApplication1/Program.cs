using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
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
            String v;
            v = Console.ReadLine();
            double x;
            x = double.Parse(v);
            double b;
            b = a * c + a * x + c * x;
            Console.WriteLine("{0:F4}", b);
        }
    }
}
