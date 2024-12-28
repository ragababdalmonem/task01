using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_12_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int []array1 = { 1, 7, 3, 4, 5, 6 };
            int[] array2 = { 1, 2, 6, 4, 5 };
            int[] array3 = { 1, 3, 2, 4 };
            int[] array4;

            int[][] jadge_1 = { array1, array2, array3 };

            foreach(int []i in jadge_1)
            {
                Array.Sort(i);
                Array.Reverse(i);
                foreach(int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
