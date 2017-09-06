using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop Class
            //int n;
            //Console.WriteLine("Give number of levels-");
            //n = Convert.ToInt32(Console.ReadLine());
            //Loop loop = new Loop();
            //loop.genPattern(n);

            //Palindrome Class
            //Console.WriteLine("Provide the input stream-");
            //String str = Console.ReadLine();
            //Palindrome pal = new Palindrome();
            //pal.checkPalindrome(str);

            //Duplicate Class --Incomplete
            //String str = "Yellow is the color of Yellow lamp.";
            //RemoveDuplicate removeDuplicate = new RemoveDuplicate();
            //removeDuplicate.removeDuplicate(str);

            //AlternateRowPrint
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a string");
            //String n = Console.ReadLine();
            //AlternateRowPrint arp = new AlternateRowPrint();
            //arp.alternateBlankPrint(n);

            //Rectangle with 3 Cols and 5 Rows
            //Console.WriteLine("Enter an integer");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Col3Row5 c3r5 = new Col3Row5();
            //c3r5.genRectangle(n);

            //Celsius degrees to Fahrenheit
            //Console.WriteLine("Enter the temperature in celsius-");
            //double cel = Convert.ToDouble(Console.ReadLine());
            //CelsiusToFahrenheit cToF = new CelsiusToFahrenheit();
            //cToF.CelToFahr(cel);

            //Longest word in a string
            //String str = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            //LongestWord lw = new LongestWord();
            //lw.longestWordInString(str);

            //Sum of first 500 Prime numbers
            //SumOfFirst500PrimeNumbers sum = new SumOfFirst500PrimeNumbers();
            //sum.CalcSum();

            //Sum of the digits of a number
            //Console.WriteLine("Enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //SumOfDigits sOd = new SumOfDigits();
            //sOd.sumOfDigit(num);

            //Reverse String
            //String str = "Display the pattern like pyramid using the alphabet.";
            //ReverseString rs = new ReverseString();
            //rs.reverseString(str);

            //Leap Year Finding
            //Console.WriteLine("Enter a year -");
            //int year = Convert.ToInt32(Console.ReadLine());
            //LeapYear ly = new LeapYear();
            //ly.CheckLeapYear(year);

            //Larget number among three
            LargestAmongThree lat = new LargestAmongThree();
            lat.checkLargest();

            Console.ReadLine();
        }
    }
}
