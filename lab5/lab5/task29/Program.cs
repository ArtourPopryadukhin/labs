using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task29
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xt, Yt, Xp, Yp, H, W;
            String t = Console.ReadLine();
            Xt = double.Parse(t);
            t = Console.ReadLine();
            Yt = double.Parse(t);
            t = Console.ReadLine();
            Xp = double.Parse(t);
            t = Console.ReadLine();
            Yp = double.Parse(t);
            t = Console.ReadLine();
            H = double.Parse(t);
            t = Console.ReadLine();
            W = double.Parse(t);
            if (H > 0.1 && H < 0.3 && W > 1 && W < 4 && Xt > Xp && Xt <= 4 && Xt >= 1 && Yt > Yp && Yt <=0.1 && Yt >= 0.3)
            {
                Console.WriteLine("Значение должно быть неотрицательным");
                return;
            }
            if (H > 0)
            {
                Console.WriteLine("Высота должна быть положительна");
                return;
               
            }
            if ( W < 0)
            {
                Console.WriteLine("Ширина должна быть положительна");
                return;
            }
            
        
        }
    }
}
