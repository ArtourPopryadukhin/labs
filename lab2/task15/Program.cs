using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            double a;
            a = double.Parse(t);
            double b;
            if (a <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение T должно быть выше абсолютного нуля"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            b = a * 1.8 + 32;
            Console.WriteLine("{0:F4}", b);
        }
        }
    }

