using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Vehicle
    {
        public string vNumber,Name;
        public int gears;

        public Vehicle() { }
        public Vehicle(string vNum,string Name,int Gears)
        {
            this.vNumber = vNum;
            this.Name = Name;
        }

        public virtual void hasGear()
        {
            Console.WriteLine("Vehicle has Gear.");
        }
        public virtual void hasNoGear()
        {
            Console.WriteLine("Vehicle has no Gear.");
        }
        public virtual void getGears()
        {
            Console.WriteLine("Vehicle has Gear.");
        }
        public virtual void getName()
        {
            Console.WriteLine("Vehicle Name.");
        }
        public virtual void getNumber()
        {
            Console.WriteLine("Vehicle Number.");
        }
    }

    public class TwoWheeler : Vehicle
    {
        public TwoWheeler() { }
        public TwoWheeler(string vNum, string Name, int Gears) : base(vNum, Name, Gears) { }

        public override void hasGear()
        {
            Console.WriteLine("Two Wheeler may have gears.");
        }

        public override void hasNoGear()
        {
            Console.WriteLine("Two Wheeler may not have gear.");
        }

        public override void getGears()
        {
            Console.WriteLine("No. of Gears of Two Wheeler.");
        }

        public override void getName()
        {
            Console.WriteLine("Name of Two wheeler.");
        }

        public override void getNumber()
        {
            Console.WriteLine("Two Wheeler Number.");
        }
    }

    public class FourWheeler : Vehicle
    {
        public FourWheeler() { }
        public FourWheeler(string vNum, string Name, int Gears) : base(vNum, Name, Gears) { }

        public override void hasGear()
        {
            Console.WriteLine("Four Wheeler may have gears.");
        }

        public override void hasNoGear()
        {
            Console.WriteLine("Four Wheeler may not have gear.");
        }

        public override void getGears()
        {
            Console.WriteLine("No. of Gears of Four Wheeler.");
        }

        public override void getName()
        {
            Console.WriteLine("Name of Four wheeler.");
        }

        public override void getNumber()
        {
            Console.WriteLine("Four Wheeler Number.");
        }
    }

}
