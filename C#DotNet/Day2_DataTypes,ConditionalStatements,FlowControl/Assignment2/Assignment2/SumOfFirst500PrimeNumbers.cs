using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SumOfFirst500PrimeNumbers
    {
        public void CalcSum()
        {
            long result = 0;
            int number = 2;
            int count = 0;

            while (count < 500)
            {
                if (checkPrime(number))
                {
                    result = result + number;
                    count++;
                }
                number++;
            }
            Console.WriteLine("The sum of first 500 prime numbers is " + result);
        }

        public static bool checkPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
