using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task20
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
            String x;
            x = Console.ReadLine();
            double v;
            v = double.Parse(x);
            if (a <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение M должно быть положительным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            if (c <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение V должно быть положительным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            if (v <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение H должно быть неотрицательным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            double b;
            b = a * c * c / 2;
            Console.WriteLine("{0:F4}", b);
            double r;
            r = a * 9.8067 * v;
            Console.WriteLine("{0:F4}", r);
        }
    }
}
