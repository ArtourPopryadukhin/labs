using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            String b;
            b = Console.ReadLine(); // 
            String a;
            a = Console.ReadLine();
            String[] aa;
            aa = b.Split(' ');
            String[] bb;
            bb = a.Split(' ');
            int c = 0;
            Console.WriteLine(aa.Length == bb.Length);
            while (c < aa.Length)
            {
                Console.WriteLine(int.Parse(aa[c]) + " "); // Нужно преобразовать элемент лев и прав массива в числа
                Console.WriteLine(int.Parse(bb[c]) + " "); // Перемножаем числа, Выводим произведение
                Console.WriteLine(int.Parse(aa[c]) * int.Parse(bb[c]));
                
                c++;
            }
        }
    }
}
