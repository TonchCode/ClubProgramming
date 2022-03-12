using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace задача_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Points = 0;

            string path = @"text.txt";
            int id = 0;
            FileStream fs = new FileStream("id.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            id = Convert.ToInt32(sr.ReadLine());

            sr.Close();
            fs.Close();

            FileStream fs2 = new FileStream(path,FileMode.OpenOrCreate);
            sr = new StreamReader(fs2);

            string[] q = new string[id];
            string[] a1 = new string[id];
            string[] a2 = new string[id];
            string[] a3 = new string[id];
            string[] a4 = new string[id];
            int[] ra = new int[id];


            for (int i = 0; i < id; i++)
            {
                sr.ReadLine();
                q[i] = sr.ReadLine();
                a1[i] = sr.ReadLine();
                a2[i] = sr.ReadLine();
                a3[i] = sr.ReadLine();
                a4[i] = sr.ReadLine();
                ra[i] = Convert.ToInt32(sr.ReadLine());
            }
            sr.Close();
            fs.Close();

            for (int i = 0; i < id; i++)
            {
                Console.WriteLine(q[i]);
                Console.WriteLine("1) " + a1[i]);
                Console.WriteLine("2) " + a2[i]);
                Console.WriteLine("3) " + a3[i]);
                Console.WriteLine("4) " + a4[i]);
                int pick = Convert.ToInt32(Console.ReadLine());
                if (pick == ra[i])
                {
                    Points++;
                } 
            }
            Console.WriteLine("You got {0} points from the game.", Points);

            Console.ReadKey();

        }
    }
}
