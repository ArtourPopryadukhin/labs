using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            String msg, msgg;
            msg = Console.ReadLine();
            int a;
            a = int.Parse(msg);
            msgg = Console.ReadLine();
            int b;
            b = int.Parse(msgg);
            if (a >= b) { 
            while (a >= b)
            {
                Console.Write(b + " ");
                b = b - 1;
            }
            }
            else { 
            while (a <= b)
            {
                Console.Write(a + " ");
                a = a + 1;
            }
            }
        }
    }
}
