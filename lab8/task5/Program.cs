using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            String b;
            b = Console.ReadLine();
            String[] aa;
            aa = b.Split(' ');
            String[] bb;
            bb = b.Split(' ');
            int c = aa.Length * bb.Length;
            while (c >= 0)
            {
                Console.WriteLine(aa[c] + " ");
                Console.WriteLine(bb[c] + " ");
            }
        }
    }
}
