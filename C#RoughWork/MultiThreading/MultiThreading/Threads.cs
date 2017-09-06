using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingAndPaprallelProgramming
{
    class Threads
    {
        public void threads()
        {
            Thread objThread = new Thread(Function1);
            objThread.Start();
            Console.WriteLine("Main Thread!");
        }

        void Function1()
        {
            string x = "p";

            for (int i = 0; i < 1000000; i++)
            {
                x = x + x;
                Console.WriteLine(x);
            }
        }
    }
}
