using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class RemoveDuplicate
    {
        public void removeDuplicate(String str)
        {
            String[] charArray = str.Split();
            int i = 0;
            
            while(str.Length!='\0')
            {
                
                Console.WriteLine("i={0} {1}",i,charArray[i]);
                i++;
            }
        }
    }
}
