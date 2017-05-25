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
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            double b; //Переменная для результата
            b = a * Math.PI / 180;
            Console.WriteLine("{0:F4}", b);
        }
    }
}
