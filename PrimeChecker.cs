using System;
using System.Numerics;

namespace _06.Homework_Prime_Checker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            isPrimeNumber(number);
            Console.WriteLine(isPrimeNumber(number));
        }

        private static bool isPrimeNumber(long number)
        {
            
            var isPrime = true;

            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    return false;
                }
            }
            if (isPrime)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
