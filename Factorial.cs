using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _13.Homework_Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            FindFactorial(n);
        }

        private static int FindFactorial(int n)
        {
            BigInteger factorial = 1;
            do
            {
                factorial = factorial * n;
                n--;
            } while (n > 1);
            Console.WriteLine(factorial);
            return n;
        }
    }
}
