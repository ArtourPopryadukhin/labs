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
            int a, b, c;
            String t = Console.ReadLine();
            a = int.Parse(t);
            b = int.Parse(t);
            c = int.Parse(t);
           if (1000 > a || a > 9999)
            {
            Console.WriteLine("Значение A должно быть в интервале [1000, 9999]");
            }
            b = a % 10;
            c = a / 100 % 10; 
            if (b == c)
            {
                Console.WriteLine("не равно");
            }
            else { Console.WriteLine("равно"); }
            //if (1000 <= a || a <= 9999)
            //{
            //    Console.WriteLine("равно");
            //}
            //if (1000 <= a || a <= 9999)
            //{
            //    Console.WriteLine("Значение A должно быть в интервале [1000, 9999]");
            //}
        }
    }
}