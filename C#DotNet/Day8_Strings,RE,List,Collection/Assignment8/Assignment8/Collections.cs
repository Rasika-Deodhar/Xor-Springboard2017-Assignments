using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Collections
    {
        Dictionary<int,Employee> employees = new Dictionary<int,Employee>();
        
        public void getCollection()
        {
            employees.Add(1, new Employee( 1011, "Ragini", 4567.98));
            employees.Add(2, new Employee(1012, "Rakesh", 767.98));
            employees.Add(4, new Employee(7011, "Meghana", 1467.98));
            employees.Add(3, new Employee(2011, "Naresh", 3567.98));

            foreach (var item in employees)
            {
                Console.WriteLine(item.Key + " " + item.Value.ID + " " + item.Value.Name + " " + item.Value.Salary);
            }

            Console.WriteLine("Enter Id to change a particular salary = ");
            int changeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new salary = ");
            double newSal = Convert.ToInt64(Console.ReadLine());

            foreach (var item in employees.Where(i=>i.Value.ID== changeID))
            {
                item.Value.Salary = newSal;
                Console.WriteLine(item.Key + " " + item.Value.ID + " " + item.Value.Name + " " + item.Value.Salary);
            }

            foreach (var item in employees)
            {
                Console.WriteLine(item.Key + " " + item.Value.ID + " " + item.Value.Name + " " + item.Value.Salary);
            }

            Console.WriteLine("Enter Id to delete the record = ");
            int deleteID = Convert.ToInt32(Console.ReadLine());

            foreach (var item in employees.Where(i=>i.Value.ID==deleteID))
            {
                employees.Remove(item.Key);
                break;
            }

            foreach (var item in employees)
            {
                Console.WriteLine(item.Key + " " + item.Value.ID + " " + item.Value.Name + " " + item.Value.Salary);
            }
        }
    }

    class Employee
    {
        public int ID;
        public string Name;
        public double Salary;
        public Employee(int ID, string Name,double Salary)
        {
            this.ID = ID; this.Name = Name; this.Salary = Salary;
        }
    }
}
