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
            String msg, msgg;
            msg = Console.ReadLine();
            int n;
            n = int.Parse(msg);
            msgg = Console.ReadLine();
            int i;
            i = int.Parse(msgg);
            Console.Write("\"");
            while (n > i)
            {

                Console.Write("#");
                i = i + 1;
            }
            Console.Write("\"");
        }
    }
}