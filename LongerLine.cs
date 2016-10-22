using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Homework_Longer_line
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            FindLargestLine(x1, y1, x2, y2, x3, y3, x4, y4);

        }

        private static void FindLargestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double xx = (x2 - x1) * (x2 - x1);
            double yy = (y2 - y1) * (y2 - y1);
            double xx2 = (x4 - x3) * (x4 - x3);
            double yy2 = (y4 - y3) * (y4 - y3);
            double x1y1distance = Math.Sqrt(x1 * x1 + y1 * y1);
            double x2y2distance = Math.Sqrt(x2 * x2 + y2 * y2);
            double x3y3distance = Math.Sqrt(x3 * x3 + y3 * y3);
            double x4y4distance = Math.Sqrt(x4 * x4 + y4 * y4);


            double firstDistance = Math.Sqrt(xx + yy);
            double secondDistance = Math.Sqrt(xx2 + yy2);

            if (firstDistance >= secondDistance)
            {
                if (x1y1distance < x2y2distance)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
                }
            }
            if (secondDistance > firstDistance)
            {
                if (x3y3distance < x4y4distance)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
                }

                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
                }
            }
        }
    }
}