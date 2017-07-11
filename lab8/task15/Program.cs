using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            String[] aa;
            aa = a.Split(' ');
            String b = Console.ReadLine();
            String[] bb;
            bb = b.Split(' ');
            int c = 0; // Переменная в верхнем массиве
            Console.WriteLine();
            
            while (c < aa.Length)
            {
                
                Console.Write(aa[c] + " ");
                c++;
                
            }
            
            Console.WriteLine();
            int e = aa.Length;
            int f = 0; //  перебирает длину массива аа
            int d = 0; //Переменная в левом массиве
            while (d < bb.Length)
            {
                //выводим букву
                //выводим много пробелов
                //выводим палочку
                //переносим строку
                f = 0;
                
                Console.Write(bb[d]);
                
                while (e > f)
                { 
                Console.Write(" ");
                
               if (aa[f] == bb[d])
                {
                    Console.Write("+");
                }
               else
               {
                   Console.Write(" ");
               }
               f++;
                }
                d++;
                Console.WriteLine("|");
                
            }
        }
    }
}
