using System;


namespace МассивыДЗ
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первый член геометрической прогрессии P: ");
            var p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знаменатель прогрессии Q: ");
            var q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            int[] progression = new int[20];
            progression[0] = p;
            int i;
            for (i = 1; i < progression.Length; i++)
            {
                progression[i] = progression[i - 1] * q;

            }

            PrintArray(progression);
            Console.WriteLine();
            GetSquares(progression);
            Console.WriteLine();
            Geometric(progression);

            void PrintArray(int[] prints)
            {
                foreach (var print in prints)
                    Console.Write(print + " ");
            }

            int GetSquares(int[] prints)
            {
                for (int a = 0; a < prints.Length; a++)
                {
                    prints[a] *= prints[a];

                }
                foreach (var print in prints)
                    Console.Write(print + " ");
                return 0;
            }
//Следующий метод с вычислением среднего геометрического элементов массива не работает, но я решила его оставить
             double Geometric(int[] prints)
            {
                int multiply = 1;

                for (int a = 1; a < prints.Length; a++)
                {
                    multiply = multiply * prints[a]; ;

                }

                double geomAverage = Math.Pow(multiply, 1 / 20);

                Console.WriteLine("Среднее геометрическое элементов массива: " + geomAverage);
                return geomAverage;
            }




            Console.ReadKey();




        }
    }
}
