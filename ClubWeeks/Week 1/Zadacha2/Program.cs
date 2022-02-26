using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        // Задача 2: Подреждане на 3 числа в низходящ ред (най-голямото да е първо) 

        static void Main(string[] args)
        {
            /* (x<y) || (x<z) 
             * (x<y) && (x<z)
             * 
             * true  && false = false
             * 
             * true  || false = true
             * 
             * 
             * <
             * >
             * <=
             * >=
             * ==
             * !=
             */

            Console.Write("Enter number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number: ");
            int c = Convert.ToInt32(Console.ReadLine());
           
            if (a > b && a > c)
            {
                Console.WriteLine(a);
                if (b > c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b);
                if (a > c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
            }
            else if (c > b && c > a)
            {
                Console.WriteLine(c);
                if (b > a)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }

            Console.ReadKey(true);
        }
    }
}
