using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        // Задача 1: Сравняваме две числа, по-голямото(задължително да има) го умножаваме по 3 и изписваме на конзолата резултата

        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if(a < b)
            {
                Console.WriteLine(b * 3);
            }
            else
            {
                Console.WriteLine(a * 3);
            }
            Console.ReadKey(true);
        }
    }
}
