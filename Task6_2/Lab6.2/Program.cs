using System;
namespace Lab6_2
{
    class Program
    {
        static void Main()
        {
            int n;
            double b = 0;

            do
            {
                Console.Write("Чему равно n?  ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            Console.WriteLine("Сумма ряда равна:");
            for (int i = 1; i <= n; i++)
            {
                b = b + (2 * i - 1) / (Math.Pow(i, 2) * Math.Pow((i + 1.0), 2));

            }
            Console.WriteLine(b);
        }
    }
}