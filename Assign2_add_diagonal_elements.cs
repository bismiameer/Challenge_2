using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Assign2_add_diagonal_elements
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] array = new int[4, 4]
            {
                { 1, 2, 3, 4 },
                { 4, 5, 6, 7 },
                { 8, 9, 10, 11 },
                { 12, 13, 14, 15 }
            };
            Console.Write("Diagonals are: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        Console.Write(array[i, j] + "");
                        sum = sum + array[i, j];
                    }
                }
            }
            Console.WriteLine("\n Sum of the diagonal elements are: " + sum);
            Console.ReadLine();
        }
    }
}
