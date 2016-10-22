using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _13.Homework_Factorial
{
    class Trailingzeroes

    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int zeros = 0;

            int z1 = n / 5;
            int z2 = n / 25;
            int z3 = n / 125;
            int z4 = n / 625;
            zeros = z1 + z2 + z3 + z4;

          

            Console.WriteLine(zeros);

        }

    }
}