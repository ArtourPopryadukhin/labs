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
            String msg;
            msg = Console.ReadLine();
            double a; // Объявляем переменную для дробного числа
            a = Double.Parse(msg); // Преобразовываем текст в число
            // Console.WriteLine("{0:F4}", a);
            Console.Write("{1} {0} {2}", 1, 2, 3);
        }
    }
}
