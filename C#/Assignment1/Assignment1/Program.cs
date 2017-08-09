using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bird Class
            //Bird1 bird1 = new Bird1();
            //Bird2 bird2 = new Bird2();

            //bird1.walk();
            //bird1.fly();
            //bird2.walk();
            //bird2.sing();

            //AddNumbers Class
            //AddNumbers addnum = new AddNumbers();
            //addnum.Addition(1, 2, 3, 4);

            //Console.WriteLine("Provide the number of arguments to enter-");
            //int n = Convert.ToInt32(Console.ReadLine());
            //switch (n)
            //{
            //    case 2: addnum.Addition(1, 2);
            //        break;
            //    case 3: addnum.Addition(1, 2, 3);
            //        break;
            //    case 4: addnum.Addition(1, 2, 3, 4);
            //        break;
            //    default: Console.WriteLine("Wrong option!");
            //        break;
            //}
            //addnum.Addition(1, 2);
            //addnum.Addition(1, 2, 3);
            //addnum.Addition(1, 2, 3, 4);

            //User Notification
            //int n;
            //Notification notif = new Notification();
            //SMS sms = new SMS();
            //Email email = new Email();
            //Console.WriteLine("Kindly provide the notification medium- \n 1.SMS \n 2.Email");
            //n = Convert.ToInt32(Console.ReadLine());
            //switch(n)
            //{
            //    case 1:notif = new SMS();
            //        notif.notify();
            //        break;
            //    case 2:notif = new Email();
            //        notif.notify();
            //        break;
            //    default: Console.WriteLine("Wrong Choice!");
            //        break;
            //}

            //Employee Class
            Employee emp1 = new Employee1("Raj",100,"Trainee");
            emp1.ShowSal();
            Employee emp2 = new Employee2("Ram",100,"Manager");
            emp2.ShowSal();
            Employee emp3 = new Employee3("Reva",100,"HR");
            emp3.ShowSal();

            Console.ReadLine();
        }
    }
}
