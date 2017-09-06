using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingAndPaprallelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Threads t = new Threads();
            //t.threads();

            ParallelProgramming pp = new ParallelProgramming();
            pp.paralleltProgram();

            Console.Read();
        }
    }
}
