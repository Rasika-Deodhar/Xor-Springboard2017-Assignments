using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Swapping two numbers
            //Console.WriteLine("Enter 1st number -");
            //Console.Write("a =");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b =");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Swap s = new Swap();
            //s.SwapNums(a, b);

            //Number with tables
            //Console.WriteLine("Enter a number-");
            //int num = Convert.ToInt32(Console.ReadLine());
            //NumberWithTables nwt = new NumberWithTables();
            //nwt.GenTables(num);

            //Non Vowel word
            //Console.WriteLine("Enter a string-");
            //string str = Console.ReadLine();
            //NonVowels nv = new NonVowels();
            //nv.nonVowels(str);

            //Convert First Char
            //Console.WriteLine("Enter a string-");
            //string str = Console.ReadLine();
            ////ConvertFirstChar.convFirstChar(str);
            //str.convFirstChar();

            //Vehicle
            //Vehicle v1 = new TwoWheeler("MH12","TVS",0);
            //Vehicle v2 = new FourWheeler("MH12", "Maruti", 6);

            //v1.getGears();
            //v1.hasGear();
            //v1.hasNoGear();

            //v2.getName();
            //v2.getNumber();

            //IVehicle
            //IVehicle iv2 = new TwoWheelers();
            //IVehicle iv4 = new FourWheelers();
            //Program p = new Program();

            //iv2.hasGear();
            //iv2.hasNoGear();
            //iv2.getGears();

            //iv4.hasGear();
            //iv4.hasNoGear();
            //iv4.getGears();

            //p.DontKnow(iv2);
            //p.DontKnow(iv4);

            //Static Rectangle
            Console.WriteLine("Enter length and breadth of a rect=");
            Console.Write("Length = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Breadth = ");
            int b = Convert.ToInt32(Console.ReadLine());
            StaticRectangle.calRectArea(a,b);

            Console.ReadLine();
        }

        public void DontKnow(IVehicle v)
        {
            v.hasGear();
            v.hasNoGear();
            v.getGears();
        }
    }
}
