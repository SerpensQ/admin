using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            int x = Convert.ToInt32(Console.ReadLine());
            double tg = Math.Tan(x);
            double Power = 2;

            double tg2 = Math.Pow(tg, Power);
            double tg3 = tg2 + 4;
            double Sin = Math.Sin(tg3);
            double Sin2 = Sin * 2;
            double TopLine = Math.Abs(x) + Sin2;

            double BottomLine = 5.5 * x;
            double Result = TopLine / BottomLine;
            Console.WriteLine("Результат вычислений" + Result);
            Console.ReadKey();

        }
    }
}
