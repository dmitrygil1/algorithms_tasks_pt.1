using System;
class Program
{
    static void Main(string[] args)
    {
        double e = 0.00005;
        double sum = 0, i = 1, s;
        do 
        {
            s = 1 / ( (2*i-1) * (2*i + 1) );
            sum += s;
            i++;
        }
        while (s >= e);

        Console.WriteLine("Результат: {1}   {0}", i,sum);
    }
}
