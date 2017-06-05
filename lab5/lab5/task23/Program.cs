using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task23
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            String t = Console.ReadLine();
            x = double.Parse(t);
            t = Console.ReadLine();
            y = double.Parse(t);
            if (x >= 2 && y >= 0 || x >= 1 && y <= -1 )
            {

                Console.WriteLine("Точка принадлежит выбранной области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит выбранной области");
            }
        }
    }
}
