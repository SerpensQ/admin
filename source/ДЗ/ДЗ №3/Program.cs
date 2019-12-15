using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            var x = Convert.ToDouble(Console.ReadLine());
           
            var Result = (Math.Abs(x) + 2 * Math.Sin(Math.Pow(Math.Tan(x), 2) + 4) )/ 5.5 * x;
            Console.WriteLine("Результат вычислений = " + Result);
            Console.ReadKey();

        }
    }
}
