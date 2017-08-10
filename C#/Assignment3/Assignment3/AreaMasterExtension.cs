using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class CountryMaster:AreaMaster
    {
        public CountryMaster() { }

        public CountryMaster(int ID, string Code, int AreaID, string Name, string Description, AreaType Area) :base(ID,Code,AreaID,Name,Description,Area)
        {

        }

        public override AreaType Area
        {
            get
            {
                return AreaType.Country;
            }

            set
            {
                base.Area = AreaType.Country;
            }
        }
        
    }

    class StateMaster : AreaMaster
    {
        public StateMaster()
        { }

        public StateMaster(int ID, string Code, int AreaID, string Name, string Description, AreaType Area) :base(ID,Code,AreaID,Name,Description,Area)
        {

        }

        public override AreaType Area
        {
            get
            {
                return AreaType.State;
            }

            set
            {
                base.Area = AreaType.State;
            }
        }
    }

    class CityMaster : AreaMaster
    {
        public CityMaster()
        { }

        public CityMaster(int ID, string Code, int AreaID, string Name, string Description, AreaType Area) :base(ID,Code,AreaID,Name,Description,Area)
        {

        }

        public override AreaType Area
        {
            get
            {
                return AreaType.City;
            }

            set
            {
                base.Area = AreaType.City;
            }
        }
        
    }

    class DistrictMaster : AreaMaster
    {
        public DistrictMaster()
        { }

        public DistrictMaster(int ID, string Code, int AreaID, string Name, string Description, AreaType Area) :base(ID,Code,AreaID,Name,Description,Area)
        {

        }

        public override AreaType Area
        {
            get
            {
                return AreaType.District;
            }

            set
            {
                base.Area = AreaType.District;
            }
        }

    }
}
