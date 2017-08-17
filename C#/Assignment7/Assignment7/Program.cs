using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
        enum Days { Sat=1, Sun, Mon, Tue, Wed, Thu, Fri };
        enum Months : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

        public struct Emp1
        {
            //public Emp1() //error-cannot creare parameterless constructor in structure
            //{ }
            public int id;
            public string name;
        };

        public struct Emp2 //:Emp1 - cannot inherit a structure
        {
            public int id;
            public string name;
        };

        static void Main(string[] args)
        {
            //Arrays
            //Arrays a = new Arrays();
            //a.display_arrays();

            //Tuples
            Tuples t = new Tuples();
            t.create_Tuples();

            //Enum
            Console.WriteLine("Friday = " + Days.Fri);
            Console.WriteLine("December = " + Months.Dec);

            //structure
            Emp1 e1 = new Emp1();
            e1.id = 1; e1.name = "Rasika";
            Console.WriteLine("Employee 1 = " + e1.id + " " + e1.name);

            Emp2 e2 = new Emp2();
            e2.id = 2;e2.name = "Deodhar";
            Console.WriteLine("Employee 2 = " + e2.id + " " + e2.name);

            Emp1 e3 = e1;
            Console.WriteLine("Employee 3 = " + e3.id + " " + e3.name);
            
            Console.Read();
         }
     }
}
