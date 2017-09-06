using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class ErrorsException
    {
        public void ExceptionHandling()
        {
            int num1,num2;
            Console.WriteLine("Enter 1st number = ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number = ");
            num2 = Convert.ToInt32(Console.ReadLine());

            division(num1, num2);

        }

        public void division(int num1, int num2)
        {
            int result;
            try
            {
                result = num1 / num2;
                Console.WriteLine("Result = " + result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide by 0 error." + " " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error!" + " " + e.Message);
            }
        }
    }

}
