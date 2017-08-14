using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public static class ConvertFirstChar
    {
        public static void convFirstChar(this string str)
        {
            string[] temp;

            temp=str.Split();

            for (int i = 0; i < temp.Length; i++)
            {
               
                Console.Write(temp[i].Remove(1).ToUpper() + temp[i].Substring(1) + " ");
            }

        }
    }
}
