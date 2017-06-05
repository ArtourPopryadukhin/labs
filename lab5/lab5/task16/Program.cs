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
            int a, b, c;
            String t = Console.ReadLine();
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            t = Console.ReadLine();
            c = int.Parse(t);
            if (a < b)
            {
                Console.WriteLine("Треугольник не является равнобедренным");
            }
            if (b < c)
            {
                Console.WriteLine("Треугольник не является равнобедренным");
            }
            if (a < c)
            {
                Console.WriteLine("Треугольник не является равнобедренным");
            }
            if (a == b)
            {
                Console.WriteLine("Треугольник является равнобедренным.");
            }
            if (b == c)
            {
                Console.WriteLine("Треугольник является равнобедренным.");
            }
            if (a == c)
            {
                Console.WriteLine("Треугольник является равнобедренным.");
            }
            if (a < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
            }
            if (b < 0)
            {
                Console.WriteLine("Значение B должно быть неотрицательным");
            }
            if (c < 0)
            {
                Console.WriteLine("Значение C должно быть неотрицательным");
            }
        }

    }
}
