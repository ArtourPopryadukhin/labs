using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            String b;
            String t;
            t = Console.ReadLine();
            b = Console.ReadLine();
            

            String[] aa;
            aa = b.Split(' ');
          
            //    Console.WriteLine(aa[0] + " " + 0);
            //    Console.WriteLine(aa[1] + " " + 1);
            //    Console.WriteLine(aa[2] + " " + 2);
            //    Console.WriteLine(aa[3] + " " + 3);
                
            //Console.WriteLine("--------------");

            int c = 0;
          //  Console.WriteLine(aa[c] + " " + c);
          //  c++;
          //  Console.WriteLine(aa[c] + " " + c);
          //  c++;
          //  Console.WriteLine(aa[c] + " " + c);
          //  c++;
          //  Console.WriteLine(aa[c] + " " + c);
          //  c++;
            
          //Console.WriteLine("--------------");
            //c = 0;
            while (c < aa.Length)
            {
            Console.WriteLine(aa[c] + " " + c);
            c++;
            }


        }
    }
}
