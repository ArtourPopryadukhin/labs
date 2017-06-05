using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            String t = Console.ReadLine();
            a = int.Parse(t);
            if (a >= 0)
            {
                Console.WriteLine(Math.Sqrt(a));
            }
            else
            {
                Console.WriteLine(a * a);
            }
        }
    }
}
