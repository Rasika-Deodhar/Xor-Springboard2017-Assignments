using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Arrays
    {
        public void display_arrays()
        {
            //1-D array
            int[] a = new int[5] { 1,2,3,4,5};
            Console.WriteLine("Single Dimensional Array - ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
            //2-D array
            int[,] b = new int[3, 3] 
            {
                { 1,2,3}, { 4,5,6}, {7,8,9 }
            };
            Console.WriteLine("Two Dimensional Array - ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b[i,j] + "\t");
                }
                Console.WriteLine();
            }
            //Multi-Dimensional Array
            //int[,,] c = new int[1,2,3]
            //{
            //    { { 1,1,1}, { 1,1,2}, { 1,1,3} },
            //    { { 1,1,1}, { 1,1,2}, { 1,1,3} },
            //    { { 1,1,1}, { 1,1,2}, { 1,1,3} },
            //};
            //Console.WriteLine("Multi Dimensional Array - ");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(b[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Jagged Array
            int[][] d = new int[][] { new int[] { 1,2},new int[] { 1,2,3,4} };
            Console.WriteLine("Jagged Array - ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < d[i].Length; j++)
                {
                    Console.WriteLine(d[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
