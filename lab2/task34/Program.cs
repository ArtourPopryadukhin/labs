using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task34
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
            b = 3 * Math.Sin(2  * a) * Math.Cos(3 * z);
            Console.WriteLine("{0:F4}", b);
        }
    }
}
