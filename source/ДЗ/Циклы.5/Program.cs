using System;


namespace Циклы._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первой пробежки в километрах: ");
            double firstDayKM = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент увеличения длины забега: ");
            var percent = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное число километров");
            var finalNumberOfKM = double.Parse(Console.ReadLine());
            int day = 1;
            double justVariable;
           
            do
            {
                justVariable = firstDayKM * (percent / 100);
                firstDayKM = firstDayKM + justVariable;
                day++;
            }
            while (firstDayKM < finalNumberOfKM) ;
            Console.WriteLine("Лыжник пробежит больше {0} километров на {1} день", finalNumberOfKM,day);
            Console.ReadKey();

        }
       
    }
}
