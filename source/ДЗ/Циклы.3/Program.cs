using System;


namespace Циклы._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число:  ");
            int number = int.Parse(Console.ReadLine());
            int i = 1;
            Console.WriteLine("Числа, квадрат которых меньше " + number);
            while (Math.Pow(i, 2) < number)
            {
                Console.WriteLine(i);
                i++;

            }
            Console.ReadKey();
        }

    }
}
