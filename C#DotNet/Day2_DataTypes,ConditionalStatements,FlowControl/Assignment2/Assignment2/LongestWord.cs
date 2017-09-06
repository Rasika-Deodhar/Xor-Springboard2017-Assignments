using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class LongestWord
    {
        String[] charArray;
        char[] delimiterChars = {' ', ',', '.', ':','\t'};
        public void longestWordInString(String str)
        {
            int i = 0,j=0,max=0;
            charArray = str.Split(delimiterChars);
            
            foreach(string s in charArray)
            {
                if(max<s.Length)
                {
                    max = s.Length;
                    j = i;
                }
                Console.WriteLine(s);
                i++;
            }

            Console.WriteLine("Word with max. length is = " + charArray[j]);
        }
    }
}
