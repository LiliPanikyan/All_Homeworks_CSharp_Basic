using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideCircleOutsideRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check for given point (x, y) if it is within a circle K({1, 1}, 1.5)\nand out of a rectangle R(top=1, left=-1, width=6, height=2)");

            Console.WriteLine("Please enter a point X.");
            double dblX = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a point Y.");
            double dblY = double.Parse(Console.ReadLine());
            double radius = 1.5;
            double distanceD;
            int centerX, centerY;
            centerX = 1;
            centerY = 1;
            distanceD = Math.Sqrt(Math.Pow(dblX - centerX, 2) + Math.Pow(dblY - centerY, 2));
            bool insideRectangle = (-1 <= dblX) && (dblX <= 5) && (-1 <= dblY) && (dblY<= 1);
            bool insideCircle = (distanceD <= radius);
            if (insideCircle==true && insideRectangle==false)
            {
                Console.WriteLine("Point {0},{1} is inside a circle and outside of a rectangle.", dblX, dblY);
            }
            else
            {
                Console.WriteLine("Point {0},{1} is NOT inside a circle and outside a rectangle", dblX, dblY);
            }
            Console.ReadLine();
        }
    }
}
