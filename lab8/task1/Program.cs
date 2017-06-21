using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            String b;
            String t;
            t = Console.ReadLine();
            b = Console.ReadLine();
            a = int.Parse(t);

            String[] aa;
            aa = b.Split(' ');
            if (a > aa.Length)
            {
                Console.WriteLine("Число A должно быть в интервале [0, размер массива)");
            }
            else
            {
                Console.WriteLine(aa[a]);
            }
            if (String.IsNullOrWhiteSpace(b))
            {
                Console.WriteLine("Исходная строка пуста");
            }
            
        }
    }
}
