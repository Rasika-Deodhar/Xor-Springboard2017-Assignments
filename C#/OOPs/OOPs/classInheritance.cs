using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Tyre
    {
        public void TyreType()
        {
            Console.WriteLine("Type of tyre.");
        }
    }
    public class Scooter : Tyre
    {
        public void ScooterType()
        {
            Console.WriteLine("Type of Scooter.");
            TyreType();
        }
    }
    public class Car : Tyre
    {
        public void CarType()
        {
            Console.WriteLine("Type of Car.");
            TyreType();
        }
    }
}
