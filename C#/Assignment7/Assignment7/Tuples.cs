using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Tuples
    {
        public void create_Tuples()
        {
            //Simple Tuple
            Console.WriteLine("Simple Tuple-");
            var EmployeeDetails = new Tuple<string,string,double>("Rasika","Deodhar",45000.556);
            Console.WriteLine(EmployeeDetails.Item1 + " " + EmployeeDetails.Item2 + " " + EmployeeDetails.Item3);
            var EmployeeInfo = Tuple.Create("Rasika", "Deodhar", 45000.556);
            Console.WriteLine(EmployeeInfo.Item1 + " " + EmployeeInfo.Item2 + " " + EmployeeInfo.Item3);

            //Nested Tuples
            Console.WriteLine("Nested Tuple-");
            var EmployeeList = new Tuple<int,string, string, double, string, string, string,
                 Tuple<int,int>>(2, "Rasika", "Deodhar", 80.78, "ProjName", "DeptName", "Location",
                 new Tuple<int,int>(10,100));
            Console.WriteLine(EmployeeList.Item1 + " " + EmployeeList.Item2 + " " + EmployeeList.Item3 + " " + EmployeeList.Item4 + " " + EmployeeList.Item5 + " " + EmployeeList.Item6 + " " + EmployeeList.Item7);
            Console.WriteLine(EmployeeList.Rest.Item1 + " " + EmployeeList.Rest.Item2);
        }
    }
}
