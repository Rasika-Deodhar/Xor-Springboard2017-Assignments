using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment8
{
    public class ExtraWhiteSpace
    {
        public void extraSpace()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string pattern = "\\s+";
      
            Regex reg = new Regex(pattern,RegexOptions.IgnorePatternWhitespace);
            Match match = reg.Match(str);

            if(match.Success)
            {
                str = reg.Replace(str, " ");
            }

            Console.WriteLine(str);
        }
    }
}
