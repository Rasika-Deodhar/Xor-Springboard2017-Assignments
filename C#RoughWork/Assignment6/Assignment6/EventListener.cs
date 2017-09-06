using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class enterTime : EventArgs
    {
        private DateTime TimeNow;
        public DateTime Time
        {
            set
            {
                TimeNow = value;
            }
            get
            {
                return this.TimeNow;
            }
        }
    }

    public class EventCreator
    {
        public event EventHandler enter;
        public delegate void EventHandler(EventCreator ec, enterTime et);

        public void StartEvent()
        {
            //while (true)
            //{
            //    if (enter != null)
            //    {
            //        enterTime et = new enterTime();
            //        et.Time = DateTime.Now;
            //        enter(this, et);
            //    }
            //}
            int s;
            do
            {
                Console.WriteLine("Enter 1 to get time and 0 to exit.");
                s=Convert.ToInt32(Console.ReadLine());
                if (enter != null && s==1)
                {
                    enterTime et = new enterTime();
                    et.Time = DateTime.Now;
                    enter(this, et);
                }
            } while (s == 1);
        }
    }

    public class EventListener
    {
        public void Subscribe(EventCreator ec)
        {
            ec.enter += new EventCreator.EventHandler(HearEvent);
        }
        private void HearEvent(EventCreator ec, enterTime et)
        {
            System.Console.WriteLine("Time is = " + et.Time);
        }
    }
}
