using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(45));
            employees.Add(new Employee(444));
            employees.Add(new Employee(5202));

            foreach (var item in employees)
            {
                Console.WriteLine(item.ID);
            }

            SortedList<int,Employee > emps = new SortedList<int, Employee>();
            emps.Add(4, new Employee(45));
            emps.Add(1, new Employee(454));
            emps.Add(0, new Employee(5202));

            foreach (var item in emps)
            {
                Console.WriteLine(item.Key + " "+item.Value.ID);
            }

            Console.Read();
        }
    }
}
