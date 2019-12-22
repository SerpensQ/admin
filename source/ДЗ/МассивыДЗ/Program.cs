using System;


namespace МассивыДЗ
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первый член геометрической прогрессии P: ");
            var p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите знаменатель прогрессии Q: ");
            var q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите число, на которое будут умножены элементы массива:  ");
            var k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            double[] progression = new double[20];
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
           

            void PrintArray(double[] prints)
            {
                foreach (var print in prints)
                    Console.Write(print + " ");
            }

            double GetSquares(double[] prints)
            {
                for (int a = 0; a < prints.Length; a++)
                {
                    prints[a] *= prints[a];

                }
                foreach (var print in prints)
                    Console.Write(print + " ");
                return 0;
            }

             double Geometric(double[] prints)
            {
                double multiply = 1;

                for (int a = 0; a < prints.Length; a++)
                {
                    multiply *= prints[a]; ;

                }

                double geomAverage = Math.Pow(multiply, 1.0 / prints.Length);

                Console.WriteLine("Среднее геометрическое элементов массива: " + geomAverage);
                return geomAverage;
            }

            double[] clone = (double[])progression.Clone();
            double cloneOfProgression(double[] copies, double number)
            {
                for (int c = 0; c < copies.Length; c++)
                {
                   copies[c]*=number ;

                }
                foreach (var copy in copies)
                    Console.Write(copy + " ");
                return 0;
            }
            Console.WriteLine();
            cloneOfProgression(clone, k);

            

            Console.ReadKey();




        }
    }
}
