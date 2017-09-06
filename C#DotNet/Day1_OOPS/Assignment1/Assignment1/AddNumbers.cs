using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class AddNumbers
    {
        public int sum=0;

        //public void Addition(params int[] numbs)
        //{
        //    for(int i=0;i<numbs.Length;i++)
        //    {
        //        sum += numbs[i];
        //    }
        //    Console.WriteLine("The sum is = {0}",sum);
        //}

        public void Addition(int x,int y)
        {
            sum = x + y;
            Console.WriteLine("Sum of 2 numbers = {0}",sum);
        }
        public void Addition(int x, int y,int z)
        {
            sum = x + y + z;
            Console.WriteLine("Sum of 3 numbers  = {0}", sum);
        }
        public void Addition(int w,int x, int y, int z)
        {
            sum = w + x + y + z;
            Console.WriteLine("Sum of 4 numbers  = {0}", sum);
        }
    }
}
