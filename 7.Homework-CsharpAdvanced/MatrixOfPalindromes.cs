using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Height = ");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Width = ");
            int width = Int32.Parse(Console.ReadLine());
            
            string[,] matrix = new string[height, width];
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    matrix[row, col] = "" + 
                        (char)('a' + row) + 
                        (char)('a' + col + row) + 
                        (char)('a' + row);  
                }
            }
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
