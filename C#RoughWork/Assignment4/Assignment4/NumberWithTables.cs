using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class NumberWithTables
    {
        public void GenTables(int num)
        {
            int i = 0;
            while(i<10)
            {
                Console.WriteLine(num + " * " + (i+1) + " = " + (num*(i+1)));
                i++;
            }
        }
    }
}
