using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task31
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
            b = 7 * a * a - 3 * a + 6;
            Console.WriteLine("{0:F4}", b);
        }
    }
}
