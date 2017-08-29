using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeToDB;

namespace ConsoleCodeToDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dept = new DepartmentContext())
            {
                Console.WriteLine("Add Department");
                var deptObj = new Department { Id = 1,Name="IT",Location="Pune"};
                dept.Departments.Add(deptObj);
                dept.SaveChanges();
                Console.WriteLine("Record added to Department!");
            }
            Console.ReadLine();
        }
    }
}
