using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter number N in a range 0-20: ");
            string strN = Console.ReadLine();
            int n = Int32.Parse(strN);
            int width = n;
            int height = n;
            int count = 0;
            int[,] matrix = new int[height, width];

            if (1 <= n && n <= 20)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        matrix[i, y] = ++count;
                    }

                    count = i + 1;
                }
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
                Console.ReadLine();
        }  
    }
}
