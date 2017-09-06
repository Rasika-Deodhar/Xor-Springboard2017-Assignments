using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public interface IVehicle
    {
        void hasGear();
        void hasNoGear();
        void getGears();
    }
    public class TwoWheelers : IVehicle
    {
        public void getGears()
        {
            Console.WriteLine("2 wheeler gears.");
        }

        public void hasGear()
        {
            Console.WriteLine("2 wheeler may have gears.");
        }

        public void hasNoGear()
        {
            Console.WriteLine("2 wheeler may NOT have gears.");
        }
    }

    public class FourWheelers : IVehicle
    {
        public void getGears()
        {
            Console.WriteLine("4 wheeler gears.");
        }

        public void hasGear()
        {
            Console.WriteLine("4 wheeler may have gears.");
        }

        public void hasNoGear()
        {
            Console.WriteLine("4 wheeler always have gears.");
        }
    }
}
