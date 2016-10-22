using System;


namespace _05.Homework_Fibonacci_Numbers
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(Fibonacci(n)); 
            }

        }

        private static int Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int nNext = 0;
            for (int i = 1; i <= n; i++)
            {
                nNext = n1 + n2;
                n1 = n2;
                n2 = nNext;

            }
            return nNext;
        }
    }
}
        





