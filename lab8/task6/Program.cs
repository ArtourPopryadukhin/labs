﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            String z = Console.ReadLine();
            int a = int.Parse(z); 
            String x = Console.ReadLine();
            int b = int.Parse(x);
            String c = Console.ReadLine();
            String[] aa;
            aa = c.Split(' ');
            
            //Console.WriteLine(aa[0]);
            //Console.WriteLine(aa[1]);
            //Console.WriteLine(aa[2]);
            //Console.WriteLine(aa[3]);

            int d = a;
            while (d <= b)
            {
                Console.WriteLine(aa[d] + " ");
                d++;

            }
        }
    }
}
