using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task27
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
            b = Math.Sqrt(1 - Math.Sin(a * Math.PI / 180) * Math.Sin(a * Math.PI / 180));
            Console.WriteLine("{0:F4}", b);
        }
    }
}
