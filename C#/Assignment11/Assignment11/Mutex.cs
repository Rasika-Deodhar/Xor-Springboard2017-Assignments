using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment11
{
    class Mutex1
    {
        public static void Main(string[] args)
        {
            using (var mutex = new Mutex(false, "Mutex"))
            {
                if (!mutex.WaitOne(2000, false))
                {
                    Console.WriteLine("Already Instance Running...");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("App Running...");
                Console.ReadLine();
            }
        }
    }
}
