using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            String t = Console.ReadLine();
            x = int.Parse(t);
            t = Console.ReadLine();
            y = int.Parse(t);
            t = Console.ReadLine();
            z = int.Parse(t);
            if (x > y && x > z)
            {
                Console.WriteLine(x);
            }
            if (y > x && y > z)
            {
                Console.WriteLine(y);
            }
            if (z > y && z > x)
            {
                Console.WriteLine(z);
            }
        }
    }
}
