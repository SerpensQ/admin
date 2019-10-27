using System;
using System.Globalization;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите адрес Вашей электронной почты.");
            //string email = Console.ReadLine();
            //var index = email.IndexOf('@');
            //var mailbox = email.Substring(0, index);
            //var mailservice = email.Substring(index + 1);

            ////Console.WriteLine("Ваш почтовый ящик " + mailbox + " находится на сервисе " + mailservice);
            ////Console.ReadKey();
            //Console.WriteLine("Ваш почтовый ящик {0} находится на сервисе {1}", mailbox, mailservice);

            Console.WriteLine(@"C:\Users\""admin""\Desktop");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(x);
            //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            //Console.WriteLine(CultureInfo.CurrentCulture.Name);
            Console.ReadKey();
            
        }
    }
}
