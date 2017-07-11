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
            String d = Console.ReadLine();
            int x = int.Parse(d); // Индекс значения которое будет сравниваться с элем. массива
            String a = Console.ReadLine(); 
            String[] aa;
            aa = a.Split(' ');
            int c = 0; // Номер перебираемоего индекса массива
            int s = 0; // Колличество подходящих элементов массива
            int w = int.Parse(aa[x]); // Само значение
            while (c < aa.Length) // Или (c <= aa.Length - 1)
            {
                int e = int.Parse(aa[c]); // Элемент массива на позиции С
                if (e < w)
                {
                   s++; // Увеличение кол ва на 1
                }

                c++;
            }
            Console.Write(s);
        }
    }
}
