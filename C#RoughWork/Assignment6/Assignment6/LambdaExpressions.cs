using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Employee
    {
        //ID, Name, DepartmentName, ProjectName

        public int ID { get; set; }
        public string DeptName { get; set; }
        public string ProjectName { get; set; }

        public List<Employee> Employees= new List<Employee>();
    }
}
