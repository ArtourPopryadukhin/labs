using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a, b, c;
            String t = Console.ReadLine();
            r = double.Parse(t);
            t = Console.ReadLine();
            a = double.Parse(t);
            b = a * a;
            c = Math.PI * r * r;
            if (b > c)
            {
                Console.WriteLine("Площадь квадрата больше площади круга");
                return;
            }
            if (c > b)
            {
                Console.WriteLine("Площадь круга больше площади квадрата");
                return;
            }

            if (r != r * -1)
            {
                Console.WriteLine("Значение R должно быть неотрицательным");
            }
            if  (a != a * -1)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
            }
        }
    }
}
