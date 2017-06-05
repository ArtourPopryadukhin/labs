using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            String t = Console.ReadLine();
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            if (a < b)
            {
                Console.WriteLine("Максимальное" + b + "минимальное"+ a);
            }
            else
            {
                Console.WriteLine("Максимальное" + a + "минимальное" + b);
            }
        }
    }
}
