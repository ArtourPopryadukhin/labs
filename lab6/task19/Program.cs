using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            String z = Console.ReadLine();
            int a;
            a = int.Parse(z);
            int b = 0;
            
            while (b < a)
            {
                int c = b % 5;
                if (c == 0 && b != 0)
                {
                    Console.Write(" ");
                }
                //else
                //{
                    Console.Write("!");
                //}
                b++;
            }
        }
    }
}


