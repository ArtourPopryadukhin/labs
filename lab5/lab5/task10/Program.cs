using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            String t = Console.ReadLine();
            x = double.Parse(t);
            t = Console.ReadLine();
            y = double.Parse(t);
            t = Console.ReadLine();
            z = double.Parse(t);
            if (x != x * -1)
            {
                Console.WriteLine(x * x);
                Console.WriteLine(y * y);
                Console.WriteLine(z * z);
                return;
            }
            else
            {
                Console.WriteLine(x);
                Console.WriteLine(y * y);
                Console.WriteLine(z * z);
            }
            if (y != y * -1)
            {
                Console.WriteLine(x * x);
                Console.WriteLine(y * y);
                Console.WriteLine(z * z);
                return;
            }
            else
            {
                Console.WriteLine(x * x);
                Console.WriteLine(y);
                Console.WriteLine(z * z);
            }

            if (z != z * -1)
            {
                Console.WriteLine(x * x);
                Console.WriteLine(y * y);
                Console.WriteLine(z);
                return;
            }
            else 
            {
                Console.WriteLine(x * x);
                Console.WriteLine(y * y);
                Console.WriteLine(z);
            }
        }
    }
}
