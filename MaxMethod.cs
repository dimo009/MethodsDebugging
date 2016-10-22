using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Homework_Max_Method
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            GetMaxNumber(num1, num2, num3);
            
        }

        private static void  GetMaxNumber(int num1, int num2, int num3)
        {

             int maxNum = Math.Max(num1,Math.Max(num2,num3));
            Console.WriteLine(maxNum);
        }
    }
}
