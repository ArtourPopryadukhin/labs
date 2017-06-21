using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task23
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
            while (a < b)
            { 
                int c = a % 7;
                
                if (c == 0 )
                {
                    sum = sum + a;
                    
                }
                else
                {
                    sum = sum + b;
                    
                }
            }
            a++;
            Console.Write(sum);
            //while (a >= b)
            //{
            //    
            //    v = v + b;
            //    b++;
            //}
            //Console.Write();
            
        }
    }
}
