using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3000;
            int b = 24;
            while (b >= a)
            {
                Console.WriteLine(a + " ");
                a = a + 1;
            }
            if (a > b)
            {
                Console.WriteLine("Значение A должно быть не больше значения B");
            }
        }
    }
}