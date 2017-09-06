using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment8
{
    class PhoneNumberFormat
    {
        public void PhoneNumber()
        {
            Console.WriteLine("Enter your contact in format (xxx-xxxx) =");
            string phone = Console.ReadLine();
            string pat = @"^\d{3}-\d{4}$";
            Regex reg = new Regex(pat, RegexOptions.IgnoreCase);
            Match matchPatt = reg.Match(phone);

            if(matchPatt.Success)
            {
                Console.WriteLine("Correct Pattern!");
            }
            else
            {
                Console.WriteLine("INCorrect Pattern!");
            }
        }
    }
}
