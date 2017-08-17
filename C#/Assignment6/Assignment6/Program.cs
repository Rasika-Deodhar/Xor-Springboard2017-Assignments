using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        public delegate void CalculateSimpleInterest(float pricipal,float rate,int years);

        static void Main(string[] args)
        {
            //Delegates
            //Delegates d = new Delegates();
            //d.getInfo(d);

            //Action<float,float,int>action1 = new Action<float, float, int>(d.getTotalInterest);
            //action1(4, 5, 6);

            //Func<float, float, int,float> func1 = new Func<float, float, int,float>(d.returnTotalInterest);
            //Console.WriteLine("Interest is = " + func1(4, 5, 6)); 

            //Event
            //EventCreator objEC = new EventCreator();
            //EventListener objEH = new EventListener();
            //objEH.Subscribe(objEC);
            //objEC.StartEvent();

            //Lambda Expressions
            Employee e = new Employee();
            e.Employees.Add(
                new Employee { ID = 1, DeptName = "Training", ProjectName = "ABC" }
            );
            e.Employees.Add(
                new Employee { ID = 2, DeptName = "Technical", ProjectName = "XYZ" }
            );
            e.Employees.Add(
                new Employee { ID = 3, DeptName = "Software", ProjectName = "QQQ" }
            );
            e.Employees.Add(
                new Employee { ID = 4, DeptName = "Hardware", ProjectName = "PPP" }
            );
            e.Employees.Add(
                new Employee { ID = 5, DeptName = "BPO", ProjectName = "XYZ" }
            );

            foreach (Employee item in e.Employees.Where(i=>i.ID==1))
            {
                Console.WriteLine(item.ID + " " + item.ProjectName + " " + item.DeptName);
            }

            var empIDs = e.Employees.Select(i => i.ID);
            foreach (var item in empIDs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(e.Employees.Any(i => i.ProjectName.Equals("XYZ")));
            //foreach (Employee item in e.Employees.GroupBy(i => i.ProjectName).ToList())
            //{
            //    Console.WriteLine("Group by"+ item.ID + " " + item.ProjectName + " " + item.DeptName);
            //}

            //var emps = e.Employees.GroupBy(i => i.ProjectName);
            
            Console.Read();
        }
    }
}
