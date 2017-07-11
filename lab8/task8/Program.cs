using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            String z = Console.ReadLine();
            int a = int.Parse(z);
            String v = Console.ReadLine();
            String[] aa;
            aa = v.Split(' ');
           
            
            int c = aa.Length - 1;
            while (c >= 0)
            {
                //Console.Write(int.Parse(aa[c]) + " ");
                Console.Write(int.Parse(z) * int.Parse(aa[c]));
                Console.Write(" ");
                --c;
            }
        }
    }
}
