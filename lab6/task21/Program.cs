using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    class Program
    {
        static void Main(string[] args)
        {
            String z = Console.ReadLine();
            int a;
            a = int.Parse(z);
            int b = 30;
            
            while (b <= 40)
            {
                if (a == b)
                {
                    Console.WriteLine(b + "+");

                }
                else
                {
                    Console.WriteLine(b + "-");
                }
                b++;
            }
        }
    }
}
