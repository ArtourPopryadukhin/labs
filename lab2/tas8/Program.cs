using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tas8
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            int a, b;
            a = int.Parse(t);
            t = Console.ReadLine();
            b = int.Parse(t);
            int q, p;
            if (a <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение T должно быть положительным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            if (b <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение L должно быть положительным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            q = (a * 100) / b;
            p = a * 100 % b;
            Console.WriteLine("{0}шт и {1}см", q, p);

        }
    }
}
