using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task18
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, p, z;
            String t = Console.ReadLine();
            m = int.Parse(t);
            t = Console.ReadLine();
            p = int.Parse(t);
            z = int.Parse(t);
            if (p == 0)
            {
                Console.WriteLine("Значение P должно быть не равно нулю");
                return;
            }
            z = m / p;
            if (m % p == 0 )
            {
                Console.WriteLine(z);
            }
            if (m % p != 0)
            {
                Console.WriteLine("M не делится нацело на P");
            }
           
        }
    }
}
