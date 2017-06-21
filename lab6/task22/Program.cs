using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    class Program
    {
        static void Main(string[] args)
        {
            String z = Console.ReadLine();
            int a;
            a = int.Parse(z);
            int b = 0;
            while (b < 15)
            {
              
                if (b <= a)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
                b++;
            }
        }
    }
}
