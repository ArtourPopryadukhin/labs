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
            String z = Console.ReadLine();
            int a = int.Parse(z);
            String x = Console.ReadLine();
            int b = int.Parse(x);
            String v = Console.ReadLine();
            String[] aa;
            aa = v.Split(' ');
            String q;
            q = aa[b];
            aa[b] = aa[a];
            aa[a] = q;

            //Console.WriteLine(aa[0]); Из b(water) перелил в С, Из а(coffee) перелить в b, Из С перелить в a
            //Console.WriteLine(aa[1]);
            //Console.WriteLine(aa[2]);
            //Console.WriteLine(aa[3]);

            int c = 0;
            while (c < aa.Length)
            {
                Console.Write(aa[c] + " ");
                c++;

            }
        }
    }
}
