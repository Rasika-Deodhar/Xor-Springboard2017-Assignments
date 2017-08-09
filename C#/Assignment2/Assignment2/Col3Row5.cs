using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Col3Row5
    {
        public void genRectangle(int num)
        {
            int i=0, j=0;
            while (i < 5 && j<3)
            {
                if(j==1 && (i==1 || i==2 || i==3))
                {
                    Console.Write("\t");
                    j++;
                }
                else
                {
                    Console.Write(num + "\t");
                    j++;
                }

                if(j==3)
                {
                    Console.WriteLine("\n");
                    i++;
                    j = 0;
                }
            }
        }
    }
}
