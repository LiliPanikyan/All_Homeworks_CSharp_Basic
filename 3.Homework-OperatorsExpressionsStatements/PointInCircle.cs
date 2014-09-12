using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Expression checks if given point (x, y) is inside a circle K(0,0) and radius 2.");
            Console.WriteLine("Please enter a point X.");
            double dblX = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a point Y.");
            double dblY = double.Parse(Console.ReadLine());
            int radius = 2;
            double distanceD;
            int centerX, centerY;
            centerX = 0;
            centerY = 0;
            distanceD = Math.Sqrt(Math.Pow(centerX + dblX, 2) + Math.Pow(centerY + dblY, 2));
            if (distanceD<= radius)
            {
                Console.WriteLine("Point {0},{1} is inside a circle.", dblX, dblY);
            }
            else
            {
                Console.WriteLine("Point {0},{1} is outside a circle.", dblX, dblY);
            }
            Console.ReadLine();
        }
    }
}
