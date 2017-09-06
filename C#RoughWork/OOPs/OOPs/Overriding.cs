using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class BaseClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("This is the Base Class!");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void MyMethod()
        {
            Console.WriteLine("This is the Derived Class!");
        }
    }
}
