using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class AlternateRowPrint
    {
        public void alternateBlankPrint(String num)
        {
            int j;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i=0;i<4;i++)
            {
                if(i%2!=0)
                {
                    j = 0;
                    while(j!=4)
                    {
                        //Console.WriteLine(sb.Append(num, 0, num.Length) + " "); 
                        Console.Write(num);
                        j++;
                    }
                }
                else
                {
                    j = 0;
                    while (j != 4)
                    {
                        //Console.WriteLine(sb.Append(num, 0, num.Length));
                        Console.Write(num + " ");
                        j++;
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
