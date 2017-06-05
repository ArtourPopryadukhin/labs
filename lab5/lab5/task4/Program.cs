using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            String t = Console.ReadLine();
            a = int.Parse(t);
            if (a < 0)
            {
                Console.WriteLine(a *-1);
            }
            
        }
    }
}
