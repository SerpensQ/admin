using System;


namespace Циклы._6
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число ");
           int finalNumber = int.Parse(Console.ReadLine());
            
           int firstNumber=1;
            for (int i = firstNumber; i <= finalNumber; i++)
            {
                if (friendlyNumbers(friendlyNumbers(i)) == i)
                   Console.WriteLine( i + "и" + friendlyNumbers(i) + "\n");
            }
            Console.ReadKey();
        }
            static int friendlyNumbers(int x)
            {
                int res = 0;
                for (int i = 1; i <= x/2; i++)
                    if (x % i == 0) res =res+ i;
                return res;
            }
    }
}
