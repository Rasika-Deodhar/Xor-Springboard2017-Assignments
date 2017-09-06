using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class MyBase
    {
        public void myBase()
        {
            Console.WriteLine("Base Class");
        }
        public virtual void myDerived()
        {
            Console.WriteLine("Derived in base Class");
        }
    }

    public class MyDerived : MyBase
    {
        public override void myDerived()
        {
            Console.WriteLine("Derived Class");
        }
    }
}
