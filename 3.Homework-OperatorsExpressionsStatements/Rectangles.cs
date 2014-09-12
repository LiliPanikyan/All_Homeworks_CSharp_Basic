using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Calculation of a rectangle’s perimeter and area.");
            Console.Write("Please enter a weight and a height of a rectangle:");
            string strWidth = Console.ReadLine();
            string strHeight = Console.ReadLine();

            int width = Int32.Parse(strWidth);
            int height = Int32.Parse(strHeight);

            int perimeter = (width * 2) + (height * 2);
            int area = width * height;
            Console.WriteLine("Perimeter is: " + perimeter + ", Area is:" + area);
            Console.ReadLine();
        }     
    }
}
