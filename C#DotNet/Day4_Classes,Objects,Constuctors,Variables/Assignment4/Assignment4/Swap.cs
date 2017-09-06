using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Swap
    {
        public void SwapNums(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            
            Console.WriteLine("After Swapping-");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
