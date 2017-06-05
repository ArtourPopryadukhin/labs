using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task21
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            String z;
            z = Console.ReadLine();
            double c;
            c = double.Parse(z);
            if (a != 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение R1 должно быть не равно нулю"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            if (c != 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение R2 должно быть не равно нулю"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            double b;
            b = 1 / a + 1 / c;
            Console.WriteLine("{0:F4}", b);
        }
    }
}
