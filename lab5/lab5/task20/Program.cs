using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task20
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            String t = Console.ReadLine();
            x = int.Parse(t);
            t = Console.ReadLine();
            y = int.Parse(t);
            if (x <= -2 && y >= 1)
            {

                Console.WriteLine("Точка принадлежит выбранной области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит выбранной области");
            }
            //if ()
            //{
            //    Console.WriteLine();
            //}
            //if ()
            //{
            //    Console.WriteLine();
        }
    }
}

    

