using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment10MathLib;

namespace Assignment10ExceptionHandling
{
    class NumberOperations
    {
        public void options()
        {
            try
            {
            Console.WriteLine("Enter two numbers - ");
            Console.Write("1st - ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("2nd - ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1<0 || num2 < 0)
            {
                    throw (new NegativeValueException("Negative value has been entered!"));
            }

            Console.WriteLine("1.Add \n2.Subtract \n3.Multiply \n4.Divide");
            int n = Convert.ToInt32(Console.ReadLine());

            MathLib ml = new MathLib();

            
                switch (n)
                {
                    case 1:
                        n = ml.Add(num1, num2);
                        break;
                    case 2:
                        n = ml.Subtract(num1, num2);
                        break;
                    case 3:
                        n = ml.Multiply(num1, num2);
                        break;
                    case 4:
                        n = ml.Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Wrong Value!");
                        break;
                }
                Console.WriteLine("Operation result = " + n);
            }
            catch(DivideByZeroException dze)
            {
                Console.WriteLine(dze.Message);
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch(InvalidCastException ice)
            {
                Console.WriteLine(ice.Message);
            }
            //catch(NullReferenceException nre)
            //{
            //    Console.WriteLine(nre.Message);
            //}
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                if(e.InnerException!=null)
                Console.WriteLine(e.InnerException.Message);
            }
            
        }

        
    }
}
