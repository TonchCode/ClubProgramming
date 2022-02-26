using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        //Задача.1 - Намиране на лице на триъгълник.Прочита 2 променливи от конзолата(а и h) и извежда лицето на триъгълник.
        //Задача.2 - Показване в конзолата на числото pi(22/7) с десетична запетая.
        //Задача.3 - Събиране на цифрите в три-числено число. (123 ще изведе 6, 531 ще изведе 9 и тн.)

        static void Main(string[] args)
        {
            double a;
            double h;
            Console.Write("Enter side: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height to that side: ");
            h = double.Parse(Console.ReadLine());

            Console.WriteLine("Triangle face = " + a * h * 0.5);
            Console.ReadKey(true);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(22.0 / 7); // int/int = int || double / int = double

            Console.WriteLine();
            Console.WriteLine();

            int num = Convert.ToInt32(Console.ReadLine());
            int x = num % 10;
            num = num / 10;
            int y = num % 10;
            num = num / 10;
            int z = num % 10;
            Console.WriteLine(x + y + z);
            Console.ReadKey(true);      
        }
    }
}
