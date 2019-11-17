using System;

namespace Tasks
{
    class Program
    {
        static void Main()
        {
            var x = F(3, 2) + F(5, 3) + F(11, 7);
            Console.WriteLine("x={0:F3}", x);
            Console.ReadKey();
            
        }
        static double F(double x, double y)
        {
            return (Math.Sqrt(x) - Math.Sqrt(y) )/ (Math.Sqrt(x) + Math.Sqrt(y));
        }
    }
    
}
