using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ефыл35
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
            x = Console.ReadLne();
            double c;
            c = double.Parse(x);
            double b;
            b = Math.Sqrt(c * c + a * a);
            Console.WriteLine("{0:F4}", b);
        }
    }
}
