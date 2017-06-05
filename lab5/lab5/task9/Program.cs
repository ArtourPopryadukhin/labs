using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sc, Ss;
            String t = Console.ReadLine();
            Sc = double.Parse(t);
            t = Console.ReadLine();
            Ss = double.Parse(t);
            if (Sc >= 17)
            {
                Console.WriteLine("Круг не поместится в квадрате");
                return;
            }
            if (Sc <= 17)
            {
                Console.WriteLine("Круг уместится в квадрате");
                return;
            }

            if (Sc < 0)
            {
                Console.WriteLine("Площадь круга должна быть положительной");
            }
            if (Ss < 0 )
            {
                Console.WriteLine("Площадь квадрата должна быть положительной");
            }

        }
    }
}
