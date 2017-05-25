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
                Console.WriteLine("Значение А должно быть положительным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            if (c <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение H должно быть положительным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            b = a * c / 2;
            Console.WriteLine("{0:F2}", b);
        }
    }
}
