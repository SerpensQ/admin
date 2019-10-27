using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ.");
            int Symbolcode = Console.Read();
            Console.WriteLine("0x"+Convert.ToString (Symbolcode,16));
            Console.ReadKey();
        }
    }
}
