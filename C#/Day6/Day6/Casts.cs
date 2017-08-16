using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Casts
    {
        public void casting()
        {
            int a = 200000;
            
            Console.WriteLine("Integer size = " + sizeof(int)); //sizeOf operator-returns no. of bytes it uses
            Console.WriteLine("Float size = " + sizeof(float));
            Console.WriteLine("Long size = " + sizeof(long));
            Console.WriteLine("Double size = " + sizeof(double));
            Console.WriteLine("Char size = " + sizeof(char));
            //Console.WriteLine(sizeof(s)); // throws error-String cannot have predefined size, it varies acc to the string length!

            Console.WriteLine("Integer type = " + typeof(int)); //typeof operator-returns type of the data-type and used in reflection
            Console.WriteLine("Float type = " + typeof(float));
            Console.WriteLine("Long type = " + typeof(long));
            Console.WriteLine("Double type = " + typeof(double));
            Console.WriteLine("Char type = " + typeof(char));

            if (a is float)
            {
                Console.WriteLine("a is an object.");
            }
            if (a is int)
            {
                Console.WriteLine("a is an integer.");
            }
            if (a is bool)
            {
                Console.WriteLine("a is boolean.");
            }
        }

        public void casting1()
        {
            object[] myObjects = new object[6];
            myObjects[0] = new Casts();
            myObjects[1] = new Casts();
            myObjects[2] = "String type.";
            myObjects[3] = 10;
            myObjects[4] = null;

            for (int i = 0; i < myObjects.Length; i++)
            {
                //string s = myObjects[i] as string;
                int? a = myObjects[i] as int?;

                Console.Write("{0}:",i);

                if(a!=null)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    //Console.WriteLine("Not a string!");
                    Console.WriteLine("Not an integer!");
                }
            }
        }

        public void casting3()
        {
            int x = 30000000;
            double y = x;
            Console.WriteLine("Implicit conversion = {0} and {1}",x,y);

            long val = 300000000000000;
            int i = (int)val;
            Console.WriteLine("Explicit type conversion = {0} and {1}",val,i);
            //int j = checked((int)val); // throws exception
            //Console.WriteLine("Explicit type conversion = {0} and {1}", val, j);
        }

        public void casting4()
        {
            int i = 20;
            object o = i;//Box to int
            int j = (int)o;//Unbox to int

            Console.WriteLine("Boxed = " + o + " " + o.GetType());
            Console.WriteLine("Unboxed = " + j + " " + j.GetType());
        }

        public void casting5()
        {
            Casts c1 = new Casts();
            Casts c2 = new Casts();
            Casts c3 = c1;

            bool b1 = ReferenceEquals(c1, c2);
            bool b2 = ReferenceEquals(c1, c3);
            Console.WriteLine("Reference of Different instances-> c1==c2 => " + b1);
            Console.WriteLine("Reference of Same instances-> c1==c3 => " + b2);

            //virtual equal
            bool b3 = c1.Equals(c3);
            Console.WriteLine("Virtual equals = " + b3);

            //static equal
            
        }

        
    }
}
