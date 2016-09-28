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
        public static int ResultInt { get; set; } = 0;

        public static string Fibonacci(int n)
        {
            if ((A >= n) || (B >= n))
            {
                return Result;

            }
            Result = $"{Result}{A} {B} ";
            A = A + B;
            B = A + B;
            return Fibonacci(n);
        }


        public static int Factorial(int num)
        {
            return (num == 0) ? 1 : num * Factorial(num - 1);
        }
    }
}
