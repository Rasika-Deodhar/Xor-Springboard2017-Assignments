using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class AreaMaster
    {
        //int ID, Code, AreaID;
        //string Name, Description;
        //enum AreaType{Country, State, City, District};

        public int ID
        {
            get;
            set;
        }

        public string Code
        {
            get;
            set;
        }

        public int AreaID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public enum AreaType
        {
            Country, State, City, District
        }

        public virtual AreaType Area
        {
            get; set;     
        }

        public static List<AreaMaster> AreaCollection=new List<AreaMaster>();

        public AreaMaster()
        {
        }

        public AreaMaster(int ID, string Code, int AreaID, string Name, string Description, AreaType Area)
        {
            this.ID = ID;
            this.Code = Code;
            this.AreaID = AreaID;
            this.Name = Name;
            this.Description = Description;
            this.Area = Area;

            AreaCollection.Add(this);
        }

        public void GetAreaMasterByCountry(string country)
        {

        }

        public void GetAreaMasterByState(string state)
        {

        }

        public void GetAreaMasterByCity(string city)
        {

            foreach (var item in AreaCollection)
            {
                if(item.Name.Equals(city) && item.Area == AreaType.City)
                {
                    Console.WriteLine("City =" + item.Name);
                    //Console.WriteLine(city);
                    GetAreaMasterById(item.AreaID);
                }
            }
        }

        public void GetAreaMasterByDistrict(string district)
        {

        }

        public void GetAreaMasterById(int AreaID)
        {
            //Console.WriteLine("Id =" + AreaID);
            foreach (var item in AreaCollection)
            {
                if (item.ID==AreaID && item.Area == AreaType.State)
                {
                    Console.WriteLine("State =" + item.Name);
                    //Console.WriteLine(city);
                    GetAreaMasterById(item.AreaID);
                }
                else if (item.ID.Equals(AreaID) && item.Area == AreaType.Country)
                {
                    Console.WriteLine("Country =" + item.Name);
                    //Console.WriteLine(city);
                    GetAreaMasterById(item.AreaID);
                }
                if(AreaID==0)
                { break; }
            }
        }
    }
}
