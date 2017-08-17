using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Lab02
    {
        public static double task4411(double a)
        {
            return a + 7;
        }

        public static double task8428 (double a)
        {
            return a * Math.PI / 180;
        }

        public static double task1262 (double a)
        {
            double x = 5 * Math.Cos(a * Math.PI / 180);
            return x;
        }

        public static double task2790 (double a)
        {
            return Math.Sqrt(1 - Math.Sin(a * Math.PI / 180) * Math.Sin(a * Math.PI / 180));
        }

        public static double task9164 (double a, double b)
        {
            return Math.Sin(a * Math.PI / 180) * Math.Cos(b * Math.PI / 180) + Math.Cos(a * Math.PI / 180) * Math.Sin(b * Math.PI / 180);
        }

        public static double task5789 (double a, double b, double c, double d)
        {
            return Math.Sqrt((c - a) * (c - a) + (d - b) * (d - b));
        }

        public static double task5063 (double a)
        {
            return a % 360;
        }

        public static double task7711 (double a)
        {
            return Math.Sin(a * Math.PI / 180);
        }

        public static double task3832 (double a, double b, double c)
        {
            return a * b + a * c + b * c;
        }

        public static double task9354 (double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        public static double task5895 (double a, double b, double c)
        {
            return Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(c * Math.PI / 180));
        }

        public static double task7457 (double a)
        {
            return 7 * a * a - 3 * a + 6;
        }

        public static double task9865 (double a)
        {
            return 12 * a * a + 7 * a - 16;
        }

        public static double task3558 (double a, double b)
        {
            return 3 * Math.Sin(2 * a * Math.PI / 180) * Math.Cos(3 * b * Math.PI / 180);
        }

        public static double task4366 (double a, double b)
        {
            return Math.Sqrt(b * b + a * a);
        }

        public static double task5980 (double a)
        {
            return a * a;
        }
    } 
}
