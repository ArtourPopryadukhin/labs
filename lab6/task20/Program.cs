using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task20
{
    class Program
    {
        static void Main(string[] args)
        {
            String z = Console.ReadLine();
            int a;
            a = int.Parse(z);
            
            while (a > 0)
            {
                Console.WriteLine("#");
                  a = a + 1;
            }
            if (a < 0)
            {
                Console.WriteLine("N не должно быть меньше нуля");
            }
        }
    }
}
