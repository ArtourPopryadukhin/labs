using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab01
    {
        public static void task1860(String a)
        {
            Console.WriteLine("Мы стремимся к " + a);
        }

        public static void task4764(String a)
        {
            Console.WriteLine(a + " нас не остановят!");
        }

        public static void task7472(String a, String b)
        {
            Console.WriteLine(b + " " + a);
        }

        public static void task2429(String a)
        {
            Console.WriteLine("Программирование - это " + a + "!");
        }

        public static void task3862 ()
        {
            Console.WriteLine("{0:F4}", Math.PI);
            Console.WriteLine("{0:F4}", Math.E);
        }

        public static void task9231 (double a)
        {
            Console.WriteLine("{0:F4}", a);
        }

        public static void task8624(int a)
        {
            Console.WriteLine("\"" + a + "\"");
        }

        public static void task2959 (String a)
        {
            Console.WriteLine("SELECT first_name, last_name, group\nFROM students WHERE id = '{0}';", a);
        }

        public static void task7271 (int a, int b)
        {
           Console.WriteLine ("INSERT INTO points (x, y) VALUES ('{0}', '{1}');", a, b);
        }

        public static void task2632 (int a, int b, int c, String d)
        {
            Console.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" fill=\"{3}\"/>", a, b, c, d);
        }

        public static void task4343 (String a, String b, String c, String d, String e)
        {
            Console.WriteLine("User ID={0};Password={1};\nHost={2};Port={3};Database={4};", a, b, c, d, e);
        }
    }
}
