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
            String a = Console.ReadLine();
            String[] aa;
            aa = a.Split(' ');
            int c = 0;
            String b;
            //b = aa[c];
            int q = aa.Length - 1;

            while (c < q)
            {
                b = aa[c];
                aa[c] = aa[q];
                aa[q] = b;
                c++;
                --q;
                
            }
            //aa[c] = b;
            //c = 0;
            
                int w = 0;
                while (w < aa.Length)
                {
                    Console.Write(aa[w] + " ");
                    w++;
                }
            //Array.Reverse(aa);
        }
    }
}
