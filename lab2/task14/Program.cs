using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
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
            if (c <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение B должно быть положительным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            b = a * Math.Sqrt(-7 * c);
            Console.WriteLine("{0:F4}", b);
        }
    }
}
