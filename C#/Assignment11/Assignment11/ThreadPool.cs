using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment11
{
    class ThreadPool1
    {
        public static void Main(String[] args)
        {
            //Thread[] t = new Thread[10];
            object o = null;
            //ThreadPool.QueueUserWorkItem(new WaitCallback(fun1),o);

            Parallel.For(0, 10, x => fun2());

            Console.Read();
        }

        public static void fun1(object o)
        {

            Console.WriteLine("Fun1 method!");
        }
        public static void fun2()
        {

            Console.WriteLine("Fun2 method!");
        }
    }
}
