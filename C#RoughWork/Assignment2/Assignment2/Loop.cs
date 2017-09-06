using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Loop
    {
        public void genPattern(int n)
        {
            int i=0, j=0,k=n-1;
            //for (i = 0; i < n; i++)
            //{
            //    for (j = 0; j < n; j++)
            //    {
            //        if ((i + j) >= (n - 1))
            //        {
            //            Console.Write("*\t");
            //        }
            //        else
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine("\n");
            //}
            while (i < n && j < n)
            {
                if ((i + j) >= (n - 1))
                {
                    Console.Write("*\t");
                    j++;
                }
                else
                {
                    Console.Write("\t");
                    j++;
                }
                
                if (j == (n))
                {
                    Console.WriteLine("\n");
                    i++;
                    j = 0;
                }
            }
        } 
    }
}
