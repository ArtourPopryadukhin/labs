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
            
            String a = Console.ReadLine();
            String[] aa;
            aa = a.Split(' ');
            int c = aa.Length - 1;
            String b;
            b = aa[c];
            
            while (c > 0)
            {
            aa[c] = aa[c - 1];
            --c;
            }
            aa[c] = b;
            c = 0;
            
            while (c < aa.Length)
            {
                Console.Write(aa[c] + " ");
                c++;

            }
        }
    }
}
