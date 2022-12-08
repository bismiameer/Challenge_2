using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Assign2_Sum_array
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, num, sum = 0;
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + num + " elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < num; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of all elements of array: " + sum);
            Console.ReadLine();
        }
    }
}