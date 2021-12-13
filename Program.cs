using System;
using System.Diagnostics;
namespace structure6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть значення m: ");
            long m = long.Parse(Console.ReadLine());
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            Iteration(m);
            stopwatch1.Stop();
            string str1 = Convert.ToString(Iteration(m));
            Console.WriteLine("Витрачено наносекунд на виконання ітеративного метода: " + 100 * stopwatch1.ElapsedTicks);
            Console.WriteLine(str1);
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Recursion(m);
            stopwatch2.Stop();
            string str2 = Convert.ToString(Recursion(m));
            Console.WriteLine("Витрачено наносекунд на виконання рекурсивного метода: " + 100 * stopwatch2.ElapsedTicks);
            Console.WriteLine(str2);
            Console.ReadLine();
        }
        static double Iteration(long m)
        {
            double q = 1;
            for(double b = 1; b<=m; b++)
            {
                q *= 1 / (2 * b - 1); 
            }
            return q;

        }
        static double Recursion(double m)
        {
            double t = 1;
            if(m>=1)
            {
                t = 1 / (2 * m - 1) * Recursion(m - 1);
            }
            return t;
        }
    }
}
