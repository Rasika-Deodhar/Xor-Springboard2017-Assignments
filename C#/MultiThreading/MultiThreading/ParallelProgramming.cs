using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingAndPaprallelProgramming
{
    class ParallelProgramming
    {
        public void paralleltProgram()
        {
            Parallel.For(0, 100000, x => Function1());
            Console.ReadLine();
        }

        void Function1()
        {
            string x = "p";

            for (int i = 0; i < 100000; i++)
            {
                x = x + x;
                Console.WriteLine(x);
            }
        }
    }
}
