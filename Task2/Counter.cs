using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class Counter
    {
        public static int A { get; set; } = 0;
        public static int B { get; set; } = 1;
        public static string Result { get; set; } = string.Empty;


        public static int Fibonacci(int n)
        {
            if ((A >= n) || (B >= n))
            {
                PrintResult();
                return 0;
            }
            Result = $"{Result}{A} {B} ";
            A = A + B;
            B = A + B;
            return Fibonacci(n);
        }

        public static void PrintResult()
        {
            Console.WriteLine(Result);
        }

        public static int Factorial(int n)
        {
            if (n <= 1)
            {
                Result = n.ToString();
                PrintResult();
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
