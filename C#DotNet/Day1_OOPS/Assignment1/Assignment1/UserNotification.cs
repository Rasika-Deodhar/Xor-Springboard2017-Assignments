using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Notification
    {
        public virtual void notify()
        {
            Console.WriteLine("User Notification!");
        }
    }

    class SMS : Notification
    {
        public override void notify()
        {
            Console.WriteLine("User Notified through SMS");
        }
    }

    class Email : Notification
    {
        public override void notify()
        {
            Console.WriteLine("User Notified through Email");
        }
    }
}
