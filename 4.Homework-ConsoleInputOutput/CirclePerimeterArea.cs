using System;

namespace CircleperimeterArea
{
    class CirclePerimeterArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of a circle:");
            Double radius = Convert.ToDouble(Console.ReadLine());
            double perimeter = (2* Math.PI * radius);
            double area = (Math.PI * radius);
            string outPut = string.Format("Perimeter is: {0:F2}", perimeter);           
            Console.WriteLine(outPut);
            outPut = string.Format("Area is: {0:F2}", area);
            Console.WriteLine(outPut);
            Console.ReadLine();
        }
    }
}