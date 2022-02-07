using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, f = 0;
            double m = 15;
            double z = (Math.PI / 2 - Math.PI / 4) / m;
            for (x= Math.PI / 4; x <= Math.PI / 2; x += z)
            {
                f = 1/ Math.Tan(x);
                Console.WriteLine("X: {0:F3}; Y: {1:F3}", x, f);
            }
        }
    }
}