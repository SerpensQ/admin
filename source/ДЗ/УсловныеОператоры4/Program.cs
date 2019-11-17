using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УсловныеОператоры4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение Х");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine(FX(x));
            Console.ReadKey();

        }
        static double FX(double x)
        {
            if (x > 1)
                return 2 - x;
            else if (x <= 1 & x >= -1)
                return Math.Pow(x, 2);
            else if (x < -1)
                return 1;
            else
                return 0;

        }
    }
}
