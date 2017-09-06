using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment11
{
    public class MultiThreads
    {
        public void multiThreads()
        {
            Thread t1 = new Thread(function1);
            t1.Start();
            Thread t2 = new Thread(function2);
            t2.Start();
             
        }

        public void function1()
        {
            Console.WriteLine("This is Function1 with thread 1");
        }

        public void function2()
        {
            Console.WriteLine("This is Function2 with thread 2");
        }
    }
}
