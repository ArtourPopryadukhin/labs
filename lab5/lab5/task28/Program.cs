using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task28
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            String t = Console.ReadLine();
            a = double.Parse(t);
            t = Console.ReadLine();
            b = double.Parse(t);
            t = Console.ReadLine();
            c = double.Parse(t);
            t = Console.ReadLine();
            d = double.Parse(t);
            if (a < 0 || b < 0 || c < 0 || d < 0)
            {
                Console.WriteLine("Значение должно быть неотрицательным");
                return;
            }
            if (b > d && a > d)
            {
                Console.WriteLine("Размещение невозможно");
               
            }
            else
            {
                Console.WriteLine("Размещение возможно");}
            
        }
    }
}
