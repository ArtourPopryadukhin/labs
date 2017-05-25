using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t = Console.ReadLine();
            int a;
            a = int.Parse(t);
            int b;
            if (a <= 0)
            { // если А имеет некооректное знание
                Console.WriteLine("Значение А должно быть положительным"); // Выводим ошибку
                return; // Завершаем работу программы
            }
            b = a * a * a;
            Console.WriteLine(b);
        }
    }
}
