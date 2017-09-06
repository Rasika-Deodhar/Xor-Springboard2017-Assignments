using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Palindrome
    {
        public void checkPalindrome(String str)
        {
            int i = 0,j=str.Length-1,flag=0;
            while(i<str.Length)
            {
                if (str[i] == str[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    flag = 1;
                    break;
                }
            }
            if(flag==1)
            {
                Console.WriteLine("String is NOT a Palindrome!");
            }
            else
            {
                Console.WriteLine("String is a Palindrome!");
            }
        }
    }
}
