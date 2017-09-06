using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment11
{
    class Semaphores
    {
        static Semaphore s1 = new Semaphore(3, 3);
        public static void Main(string[] args)
        {
            
            Thread[] t = new Thread[10];

            for (int i = 0; i < 10; i++)
            {
                t[i] = new Thread(function1);
                t[i].Name = "Thread" + (i+1);
            }
            for (int i = 0; i < 10; i++)
            {
                t[i].Start();
            }

            Console.ReadLine();
        }

        public static void function1()
        {
            int i = 0;
            while(i<10)
            {
                Console.WriteLine("Waiting..");
                s1.WaitOne();
                Console.WriteLine("Acquiring..." + Thread.CurrentThread.Name);
                s1.Release();
                i++;
            }
        }
    }
}
