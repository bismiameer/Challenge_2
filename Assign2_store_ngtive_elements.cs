using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Assign2_store_ngtive_elements
    {
        static void Main(string[] args)
        {
            int n;
            int[] array = new int[100];
            int[] array1 = new int[100];
            Console.WriteLine("Enter the number of elements in the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array: ");
            for(int i=0;i<n;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The negative numbers in the array are: ");
            for (int i = 0; i < n; i++)
            {
                if(array[i]<0)
                {
                    array1[i] = array[i];
                    Console.Write(array1[i] +" ");
                }
            }
            Console.ReadLine();
        }
    }
}
