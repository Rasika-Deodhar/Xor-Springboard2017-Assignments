using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment11
{
    class Lock
    {
        int num1, num2;

        public void locking()
        {
            Lock l = new Lock();

            new Thread(l.divide).Start();
            new Thread(l.divide).Start();
            divide();
            //l.divide();
            
        }

        public void divide()
        {
            Random r = new Random();

            for (long i = 0; i < 1000; i++)
            {
                lock(this)
                {
                    num1 = r.Next(1, 1000);
                    num2 = r.Next(1, 1000);
                    int result = num1 / num2;
                    Console.WriteLine("Result = " + result);
                    num1 = 0;
                    num2 = 0;
                }
            }
        }
    }
}
