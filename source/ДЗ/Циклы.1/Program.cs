using System;

namespace Циклы._1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Введите конечное число дюймов:  ");
            double inch = double.Parse(Console.ReadLine());
            Console.Write("Введите шаг :  ");
            double step = double.Parse(Console.ReadLine());
            for (double i = 1; i <= inch; i += step)
            {
                Console.Write(i + "in. = "); Console.Write(i * 2.54 + "cm.\n");
            }
           
            Console.ReadKey();

        }

    }

}
