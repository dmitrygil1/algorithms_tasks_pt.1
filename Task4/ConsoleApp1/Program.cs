using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double F;
            Console.WriteLine("Введите х");
            // Преобразуем строковое значение в целочисленное
            x = int.Parse(Console.ReadLine());

            if (x < 0)
                F = 0;
            else if (x >= 0 && x <= 1)
                F = 1 / (Math.Pow(x, 2) + 1);
            else if (x > 1 && x <= 4)
                F = Math.Pow(x, 3);
            else
                F = 64 + Math.Log (x,8);
            Console.WriteLine(" F =" +F );
            Console.ReadKey();
        }
    }
}