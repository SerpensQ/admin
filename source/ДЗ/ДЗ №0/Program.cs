using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусную меру угла");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = 15;
            int C = 113;
            int D = 37;
            double Sin1 = Math.Sin(B);
            double Sin2 = Math.Sin(C);
            double Sin3 = Math.Sin(D);
            double Sin4 = Math.Sin(A);
            double Cos1 = Math.Cos(B);
            double Cos2 = Math.Cos(C);
            double Cos3 = Math.Cos(D);
            double Cos4 = Math.Cos(A);

            double result = Math.Round(Sin4, 3);
            Console.WriteLine("Синус Вашего угла=" + result);

            double result1 = Math.Round(Cos4, 3);
            Console.WriteLine("Косинус Вашего угла="+ result1);

            double result2 = Math.Round(Sin1, 3);
            Console.WriteLine("Синус угла 15=" + result2);

            double result3 = Math.Round(Cos1, 3);
            Console.WriteLine("Косинус угла 15=" + result3);

            double result4 = Math.Round(Sin3, 3);
            Console.WriteLine("Синус угла 37=" + result4);

            double result5 = Math.Round(Cos3, 3);
            Console.WriteLine("Косинус угла 37=" + result5);

            double result6 = Math.Round(Sin2, 3);
            Console.WriteLine("Синус угла 113=" + result6);

            double result7 = Math.Round(Cos2, 3);
            Console.WriteLine("Косинус угла 113=" + result7);

           

            Console.ReadKey();



        }
    }
}
