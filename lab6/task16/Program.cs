using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task16
{
    class Program
    {
        static void Main(string[] args)
        {
            String z = Console.ReadLine();
            int n;
            n = int.Parse(z);
            int b;
            b = int.Parse(z);
            while (n > 0)
            {
                Console.WriteLine(1 + 1 / n + " ");
                
                n++;
            }
            Console.Write(b);
        }
    }
}
