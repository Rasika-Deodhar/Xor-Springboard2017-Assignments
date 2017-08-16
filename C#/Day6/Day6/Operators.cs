using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Operators
    {
        public void checkedUnchecked()
        {
            int a = 1000000,b= 1000000;
            //Console.WriteLine("Checked = " + checked(a*b)); //gives exception
            //Console.WriteLine("Unchecked = " + unchecked(a*b)); //gives some negative garbage value & is default

            //Console.WriteLine("Check within an uncheck = " + unchecked(checked(a*b)));
            //Console.WriteLine("Uncheck within a check = " + checked(unchecked(a * b)));

            try
            {
                Console.WriteLine("Checked = " + checked(a * b));
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
