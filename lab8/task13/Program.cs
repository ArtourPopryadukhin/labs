using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            String d = Console.ReadLine();
            //int x = int.Parse(d);
            String[] aa= {"a", "b", "c", "d" , "e", "f", "g"};
            //aa = a.Split(' ');
            
            //if (x == aa[1])
            //{
            //    Console.WriteLine("b+");
            //}
            //else
            //{
            //    Console.WriteLine("b");
            //}
            //if (x=="c")
            //{
            //    Console.WriteLine("c+");
            //}
            //else
            //{
            //    Console.WriteLine("c");
            //}

            int c = 0;
            while (c < aa.Length)
            {
                if (d == aa[c])
                {
                    Console.Write(aa[c]);
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine(aa[c]);
                }
                c++;
            }
            
        }
    }
}
