using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {
        // Статическая типизация (место под прогр. выделяется при кампиляции)
        static int f(int x, int y)
        {
            x++;
            y -= 2;
            return x + y;
        }
        static void Main(string[] args)
        {
            int x = 5, y = 6;
            Console.WriteLine(f(x, y) + " x=" + x + " y=" + y);
            Console.ReadKey();
        }
    }
}