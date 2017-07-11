using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task26
{
    class Program
    {
        static void Main(string[] args)
        {
            String z = Console.ReadLine();
            int a;
            a = int.Parse(z);
            String x = Console.ReadLine();
            int b;
            b = int.Parse(x);
            int sum = 0;
            while (a <= b)
            {
                if (a % 7 == 0)
                {
                    
                    sum = sum + a;
                }
                
                a++;
            }
            Console.Write(sum);
            
        //    while (a <= b)
        //    {
        //        sum = sum + a;
        //        a++;
        //    }
        //    Console.WriteLine(sum);
        }
    }
}
