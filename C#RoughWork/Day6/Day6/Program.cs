using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operators
            //Operators o = new Operators();
            //o.checkedUnchecked();

            //Casts
            //Casts c = new Casts();
            //c.casting();
            //c.casting1();
            //c.casting3();
            //c.casting4();
            //c.casting5();

            MyBase derivedObj = new MyDerived();
            derivedObj.myBase();//only base method is accessible
            derivedObj.myDerived();
            
            MyBase baseObj = new MyBase();
            baseObj.myBase(); //only base method is accessible-obvious

            MyDerived derivedCopy1 = (MyDerived)derivedObj;
            derivedCopy1.myBase();

            //MyDerived derivedCopy2 = (MyDerived)baseObj; //throws exception while compilation
            //derivedCopy2.myBase();

            Console.ReadLine();
        }
    }
}
