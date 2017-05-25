using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            int a;
            a = int.Parse(t);
            int q;
            q = a % 360;
            Console.WriteLine("{0}", q);
        }
    }
}
