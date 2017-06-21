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
            String b;
            b = Console.ReadLine();
            String[] aa;
            aa = b.Split(' ');
            int c = aa.Length - 1;
            while (c >= 0)
            {
                Console.Write(aa[c] + " ");
                ;
            }
        }
    }
}
