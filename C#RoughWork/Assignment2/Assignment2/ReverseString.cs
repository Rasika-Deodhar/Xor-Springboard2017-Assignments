using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ReverseString
    {
        public void reverseString(String str)
        {
            //int length = str.Length - 1;
            int len = 0;
            String reversestring = "";
            String[] charArray = str.Split();
            len = charArray.Length-1;
            while (len >= 0)
            {
                reversestring = reversestring + charArray[len] + " ";
                len--;
            }

            Console.WriteLine("Given String = " + str);
            Console.WriteLine("Reverse of String is = " + reversestring);
        }
    }
}
