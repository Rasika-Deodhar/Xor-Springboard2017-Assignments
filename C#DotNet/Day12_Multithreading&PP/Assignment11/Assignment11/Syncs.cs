using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment11
{
    class Syncs
    {
        Random r = new Random();
        public void syncs()
        {
            //Console.WriteLine("Locking");
            //new Thread(locks).Start();
            //new Thread(locks).Start();

            Console.WriteLine("Mutex");
            mutexes();
        }

        public void locks()
        {
            lock (this)
            {
                int alpha = r.Next(0,5);
           
                for (int i = 0; i < 10; i++)
                {
                    if (alpha == 0)
                        Console.WriteLine("Exception!");
                    Console.WriteLine("No exception!");
                }
            }
        }

        public void mutexes()
        {
            //using (var mutex1 = new Mutex(false, "Mutex"))
            //{
            //    if(!mutex1.WaitOne(2000,false))
            //    {
            //        Console.WriteLine("Already Instance Running...");
            //        Console.ReadLine();
            //        return;
            //    }
            //    Console.WriteLine("App Running...");
            //    Console.ReadLine();
            //}
            Console.WriteLine("Mutex Called");
        }

        public void semaphores()
        {

        }
    }
}
