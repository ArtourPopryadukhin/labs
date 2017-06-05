using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            String z= Console.ReadLine();
            int a;
            a = int.Parse(z);
            String x = Console.ReadLine();
            int b;
            b = int.Parse(x);
            int sum = 0;
            while (a < b || a > b)
            {
                sum = sum + b;
                a = a + 1;
            }
            Console.Write(sum);
        }
    }
}
