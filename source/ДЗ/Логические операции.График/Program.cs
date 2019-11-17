using System;

namespace Домашняя_работа_с_графиками
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Input("x");
            var y = Input("y");
            Console.WriteLine("Принадлежность точки графику " + Graphic(x, y));
            Console.ReadKey();

            
        }
        static bool Graphic(double x, double y)
        {
            return y > 1 || y < - 3;
        }
        static double Input(string Name)
        {
            Console.WriteLine("Введите координаты точек x, y");
            return double.Parse(Console.ReadLine());
           

        }
    } 
}
