using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FirstService
{
    public partial class FirstService : ServiceBase
    {
        public FirstService()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("FirstServiceSource"))
                System.Diagnostics.EventLog.CreateEventSource("FirstServiceSource", "FirstServiceLog");
            eventLog1.Source = "FirstServiceSource";
            eventLog1.Log = "FirstServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("First Service Started!!");

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 60000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("First Service Stopped!!");
        }
    }
}
