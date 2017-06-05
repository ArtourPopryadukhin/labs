using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            String t = Console.ReadLine();
            int b;
            b = int.Parse(t);
            int a = -10;
            int sum = 0;
            if (b <= -10 && b <= 10000)
            {
                Console.WriteLine("Значение должно быть в интервале [-10, 10000]");
                return;
            }
            while (a <= b)
            {
                sum = sum + a;
                a = a + 1;
            }
            Console.Write(sum);
        }
    }
}
