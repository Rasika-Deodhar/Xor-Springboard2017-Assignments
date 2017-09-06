using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class NonVowels
    {
        public void nonVowels(string nonVowel)
        {
            //char[] vowels= { 'a','e','i','o','u'};
            //char[] word = nonVowel.ToCharArray();
            //int j = 0;
            //foreach (var item in word)
            //{
            //    if(!vowels.Contains(item))
            //    {
            //        Console.Write(item);
            //    }
            //}

            string vowels = "aeiou";
            for (int i = 0; i < nonVowel.Length; i++)
            {
                if(!vowels.Contains(nonVowel[i]))
                {
                    Console.WriteLine(nonVowel[i]);
                }
            }
        }
    }
}
