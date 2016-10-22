using System;


namespace _08.HomeWork_Cortesian_Coordinate
{
    class CortesianCoordinate
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 =double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CortesianSystemCloserPoint(x1, x2, y1, y2);
        }

        private static void CortesianSystemCloserPoint(double x1, double x2, double y1, double y2)
        {
            double diagonal1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double diagonal2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));


            if (diagonal1 >= diagonal2)
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
            else if (diagonal1 < diagonal2)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
        }
    }
}

