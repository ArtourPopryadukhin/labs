using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            String a, b, c, d;
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            d = Console.ReadLine();
            Console.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" fill=\"{3}\"/>", a, b, c, d);
        }
    }
}
