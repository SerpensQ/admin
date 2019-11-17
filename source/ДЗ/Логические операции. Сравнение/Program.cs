using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            var k = Input("k");
            var m = Input("m");
            var n = Input("n");
            Console.WriteLine("Значение выражения= " + LogicalExpression(k, m, n));
            Console.ReadKey();
        }
        static bool LogicalExpression( double k, double m, double n)
        {
            return k > 15 ^ m > 15 ^ n > 15;

        }
        static double Input(string name)

        {
            Console.WriteLine("Введите число " + name);
            return double.Parse(Console.ReadLine());
        }
    }
        
}
