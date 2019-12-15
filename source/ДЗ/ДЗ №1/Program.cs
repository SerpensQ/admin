using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника");
            double b = Convert.ToInt32(Console.ReadLine());
            double area = a * b;
            double perimetr = 2 * a + 2 * b;

            var diagonal = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Площадь прямоугольника=" + area);
            Console.WriteLine("Периметр прямоугольника="+perimetr);
            Console.WriteLine("Диагональ прямоугольника = {0:F3}", diagonal);
            Console.ReadKey();
        }
    }
}
