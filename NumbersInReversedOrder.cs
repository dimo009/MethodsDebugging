using System;
using System.Linq;

namespace _04.Homework_Numbers_in_reversed_order
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double reversedNumber = ReverseNumbers(number);

            Console.WriteLine(reversedNumber);


        

        }

        private static double ReverseNumbers(double number)
        {
            bool isPositive = number > 0;
            string textNum = string.Join("", number.ToString().TrimStart('-').Reverse());
            double newNum = double.Parse(textNum);

            if (isPositive)
            {
                return newNum;
            }
            else
            {
                return -newNum;
            }
        }
    }
}
