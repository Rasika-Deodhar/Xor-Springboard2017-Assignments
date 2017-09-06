using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFirstApproach;

namespace DatabaseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new DemoEmployeeEntities())
            {
                var emp = new Employee();

                //emp.EmpID = 1;
                //emp.EmpName = "Rasika";
                //emp.Salary = 100000;
                //EmpObj.Employees.Add(emp);

                //emp = new Employee();
                //emp.EmpID = 2;
                //emp.EmpName = "Misha";
                //emp.Salary = 10000;
                //EmpObj.Employees.Add(emp);

                //emp = new Employee();
                //emp.EmpID = 3;
                //emp.EmpName = "Kashish";
                //emp.Salary = 50000;
                //EmpObj.Employees.Add(emp);

                //emp = new Employee();
                //emp.EmpID = 4;
                //emp.EmpName = "Meera";
                //emp.Salary = 100000;
                //EmpObj.Employees.Add(emp);

                //EmpObj.SaveChanges();

                //Direct Fetching
                //foreach (var item in EmpObj.Employees)
                //{
                //    Console.WriteLine("ID = " + item.EmpID + " Name = " + item.EmpName + " Salary = " + item.Salary);
                //}

                //LINQ Updation
                Employee emp1 = EmpObj.Employees.First(i => i.EmpID == 2);
                emp1.Salary = 12345;

                Employee emp2 = EmpObj.Employees.First(i => i.EmpID == 3);
                EmpObj.Employees.Remove(emp2);

                EmpObj.SaveChanges();

                Console.WriteLine("Record Inserted!");
            }

            Console.ReadLine();
        }
    }
}
