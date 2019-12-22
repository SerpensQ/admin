using System;


namespace Операторы_Цикла4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32( Console.ReadLine());
            int count = 0;
            int lastDigit = number % 10;
            

            while (number > 0)
            {
                int remainder = number % 10;

                if (remainder == lastDigit)
                {
                    count++;
                    
                }
                number = number / 10;
                
            }
            Console.WriteLine("Последняя цифра {0} встречается в числе {1} раз(a)", lastDigit, count);

            Console.ReadKey();
        }
    }
}
