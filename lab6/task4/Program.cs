using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 13;
            while (b >= a)
            {
                Console.Write(b + " ");
                b = b - 1;
            }
            if (a < b)
            {
                Console.Write("Значение A должно быть не больше значения B");
            }
        }
    }
}
