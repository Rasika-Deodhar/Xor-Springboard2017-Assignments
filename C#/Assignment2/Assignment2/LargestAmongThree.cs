using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class LargestAmongThree
    {
        public void checkLargest()
        {
            int[] arr;
            int i = 0,a,b,c;
            Console.WriteLine("Enter 3 numbers-");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if(a>b && a>c)
            {
                Console.WriteLine("Largest number is = " + a);
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("Largest number is = " + b);
            }
            else
            {
                Console.WriteLine("Largest number is = " + c);
            }
        }
    }
}
