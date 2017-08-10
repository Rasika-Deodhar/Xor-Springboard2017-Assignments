using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaMaster am1 = new CountryMaster(1,"IND",0,"India","Anything",AreaMaster.AreaType.Country);
            AreaMaster am2 = new StateMaster(2, "MH", 1, "Maharashtra", "Anything",AreaMaster.AreaType.State);
            AreaMaster am3 = new CityMaster(3, "PUN", 2, "Pune", "Anything",AreaMaster.AreaType.City);
            AreaMaster am4 = new DistrictMaster(4, "PD", 3, "Pune District", "Anything",AreaMaster.AreaType.District);
            AreaMaster am = new AreaMaster();

            foreach (var item in AreaMaster.AreaCollection)
            {
                Console.WriteLine("ID : " + item.ID);
                Console.WriteLine("Code : " + item.Code);
                Console.WriteLine("Area ID : " + item.AreaID);
                Console.WriteLine("Name : " + item.Name);
                Console.WriteLine("Description : " + item.Description);
                Console.WriteLine("Area Type : " + item.Area);
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            am.GetAreaMasterByCity("Pune");

            Console.ReadLine();
            
        }
    }
}
