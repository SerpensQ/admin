using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ.");
            int symbolCode = Console.Read();
            Console.WriteLine("0x"+Convert.ToString (symbolCode,16));
            Console.WriteLine("Следующий символ: {0}", (char)(symbolCode + 1));
            Console.ReadKey();
        }
    }
}
