using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SumOfDigits
    {
        public void sumOfDigit(int num)
        {
            int digit,sum=0,n=num;
            while(n>0)
            {
                digit = n % 10;
                sum = sum + digit;
                n /= 10;
            }
            Console.WriteLine("Given Number = " + num + " and the sum of it's digits is = " + sum);
        }
    }
}
