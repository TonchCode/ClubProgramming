using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        // Задача 3: Сравняваме 3 числа и извеждаме най-малкото от тях
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x < y && x < z)
            {
                Console.WriteLine("Smallest one = " + x);
            }
            else if (y < x && y < z)
            {
                Console.WriteLine("Smallest one = " + y);
            }
            else if (z < y && z < x)
            {
                Console.WriteLine("Smallest one = " + z);
            }
            else
            {
                Console.WriteLine("Somthing went wrong!");
            }
            Console.ReadKey(true);
        }
    }
}
