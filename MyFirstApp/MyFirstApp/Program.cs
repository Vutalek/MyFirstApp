using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];
            Random y = new Random();

            for (int i = 0; i < 5; i++)
                x[i] = y.Next(-250, 250);

            Console.WriteLine("Числа:");

            foreach (int i in x)
                Console.Write("{0}\t", i);

            Console.WriteLine("\n");
            Console.WriteLine("Отсортированные числа:");

            Array.Sort(x);

            foreach (int i in x)
                Console.Write("{0}\t", i);

            Console.ReadLine();
        }
    }
}
