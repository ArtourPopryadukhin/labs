using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11_
{
    class Program
    {
        static void Main(string[] args)
        {

            String t = Console.ReadLine();
            int a;
            a = int.Parse(t);
            int b = 500;
            int sum = 0;
            if (a >= -100 && a <= 500) {
               Console.WriteLine("Значение A должно быть в интервале [-100, 500]");
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
