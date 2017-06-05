using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2;
            String t = Console.ReadLine();
            v1 = double.Parse(t);
            t = Console.ReadLine();
            v2 = double.Parse(t);
            if (v1 < 0)
            {
                Console.WriteLine("Значение V1 должно быть неотрицательным");
                return;
            }
            if (v2 < 0)
            {
                Console.WriteLine("Значение V2 должно быть неотрицательным");
                return;
            }

            if (v1 < v2 * 0.277778)
            {
                Console.WriteLine("V2 (м/с) меньше V1(км/ч)");
            }
            else
            {
                Console.WriteLine("V1 (км/ч) меньше V2 (м/с)");
            }

        }
    }
}
