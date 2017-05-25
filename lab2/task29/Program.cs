using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task29
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            double b;
            b = (Math.Sqrt(a + 1) + Math.Sqrt(a - 1)) / (2 *Math.Sqrt(a));
            Console.WriteLine("{0:F4}", b);
        }
    }
}
