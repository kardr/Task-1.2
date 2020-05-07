using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите c:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a==b && b==c && c==a)
            {
                Console.WriteLine("Треугольник равносторонний");
            }
            else
                Console.WriteLine("Треугольник не равносторонний");

            Console.ReadKey();
        }
    }
}
