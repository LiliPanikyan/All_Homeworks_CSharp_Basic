using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static double Distance(double x1, double y1, double x2, double y2)
    {
        double distanceX = x2 - x1;
        double distanceY = y2 - y1;
        double distance = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
        return distance;
    }
    static double Perimeter(PointCollection[] point)
    {
        double perimeter = 0;
        for (int i = 0; i < point.Length - 1; i++)
        {
            perimeter += Distance(point[i].X, point[i].Y,
                                       point[i + 1].X, point[i + 1].Y);
        }
        return perimeter; 
    }
    static double Area(int[,] matrix, int rows)
    {
        double result;
        double leftSum = 0;
        double rightSum = 0;
        for (int i = 0; i < rows - 1; i++)
        {
            leftSum += (matrix[i, 0] * matrix[i + 1, 1]);
            rightSum += (matrix[i, 1] * matrix[i + 1, 0]);
        }

        result = Math.Abs((leftSum - rightSum) / 2);
        return result;
    }
    static void Main()
    {
        Console.Write("Please enter how many points(x, y) you want to use: ");
        int n = int.Parse(Console.ReadLine());
        PointCollection[] point = new PointCollection[n];
        int[,] matrix = new int[n, 2];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Points(x, y) :  ", i);
            string str = Console.ReadLine();
            string[] input = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            point[i] = new PointCollection() { X = int.Parse(input[0]), Y = int.Parse(input[1]) };
            matrix[i, 0] = int.Parse(input[0]);
            matrix[i, 1] = int.Parse(input[1]);
        }
        Console.WriteLine("Polygon's perimeter is: {0:F2}", Perimeter(point));
        Console.WriteLine("Polygon's area is: {0:F2}", Area (matrix, n));
        Console.ReadLine();
    }

    public class PointCollection
    {

        public int X { get; set; }

        public int Y { get; set; }
    }

}
        
    



        






