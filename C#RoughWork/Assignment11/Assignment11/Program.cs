using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Function Starting...");
            //Console.ReadLine();
            //MultiThreads mt = new MultiThreads();
            //mt.multiThreads();

            //Background not runnable
            //ForegroundBackground fgbg = new ForegroundBackground();
            //fgbg.threads();

            //Thread t1 = new Thread(function1);
            //Thread t2 = new Thread(function2);
            //t2.IsBackground = true;
            //t1.Start();
            //t2.Start();

            //Console.WriteLine("Main Function Ending...");
            //t2.Start();

            //Lock l = new Lock();
            //l.locking();

            Syncs s = new Syncs();
            using (var mutex = new Mutex(false, "Mutex"))
            {
                if(!mutex.WaitOne(2000,false))
                {
                    Console.WriteLine("Already Instance Running...");
                    Console.ReadLine();
                    return;
                }
                s.syncs();
            }
               
            Console.ReadLine();
        }

        public static void function1()
        {
            Console.WriteLine("This is function1!");
            Console.ReadLine();
        }

        public static void function2()
        {
            Console.WriteLine("This is function2!");
        }
    }
}
