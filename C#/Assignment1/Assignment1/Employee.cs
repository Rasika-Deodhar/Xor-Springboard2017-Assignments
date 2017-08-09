using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Employee
    {
        public String name, designation;
        public int salary;
        public Employee()
        {

        }
        public Employee(String name,int salary,String designation)
        {
            this.name = name;
            this.salary = salary;
            this.designation = designation;
        }

        public virtual void ShowSal()
        {
            Console.WriteLine("Show salary method");
        }
    }

    public class Employee1 : Employee
    {
        
        public Employee1(String name, int salary, String designation):base(name,salary,designation)
        {
        }
        public override void ShowSal()
        {
            Console.WriteLine("Salary of Employee 1 is = {0}",(this.salary*100));
        }
    }

    public class Employee2 : Employee
    {
        public Employee2(String name, int salary, String designation):base(name,salary,designation)
        {
        }
        public override void ShowSal()
        {
            Console.WriteLine("Salary of Employee 2 is = {0}", (salary * 200));
        }
    }

    public class Employee3 : Employee
    {
        public Employee3(String name, int salary, String designation) : base(name, salary, designation)
        {
        }
        public override void ShowSal()
        {
            Console.WriteLine("Salary of Employee 3 is = {0}", (salary * 300));
        }
    }
}
