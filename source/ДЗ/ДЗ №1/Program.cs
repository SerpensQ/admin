using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника");
            int b = Convert.ToInt32(Console.ReadLine());
            int AREA = a * b;
            int PERIMETR = 2 * a + 2 * b;
            int Power = 2;
            double e = Math.Pow(a, Power);
            double f = Math.Pow(b, Power);
            double DIAGONAL = Math.Sqrt(e + f);
            Console.WriteLine("Площадь прямоугольника=" + AREA);
            Console.WriteLine("Периметр прямоугольника="+PERIMETR);
            Console.WriteLine("Диагональ прямоугольника=" + DIAGONAL);
            Console.ReadKey();
        }
    }
}
