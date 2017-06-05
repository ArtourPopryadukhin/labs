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
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            String z;
            z = Console.ReadLine();
            double c;
            c = double.Parse(z);
            double b;
            if (a <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            if (c <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение Y должно быть не отрицательным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            b = -5 * Math.Sqrt(a + Math.Sqrt(c));
            Console.WriteLine("{0:F4}", b);
        }
    }
}
