using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    abstract class classAbstract
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("Animal have sound.");
        }
    }

    class Dog:classAbstract
    {
        public override void eat()
        {
            Console.WriteLine("Dog Eats!");
        }
    }
}
