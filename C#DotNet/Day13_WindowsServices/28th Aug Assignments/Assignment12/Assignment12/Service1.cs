using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment12
{
    public partial class MonitorDirectoryService : ServiceBase
    {
        //string mainPath = ;
        //string backupPath = @"D:\Assignments_and_Notes\C#\28th Aug Assignments\BackupFile\";

        public MonitorDirectoryService()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("DirectoryMonitorServiceSource"))
                System.Diagnostics.EventLog.CreateEventSource("DirectoryMonitorServiceSource", "DirectoryMonitorLog");
            DirectoryMonitorLog.Source = "DirectoryMonitorServiceSource";
            DirectoryMonitorLog.Log = "DirectoryMonitorLog";
        }

        protected override void OnStart(string[] args)
        {
            DirectoryMonitorLog.WriteEntry("Directory Monitoring Started!");

            
           // fileSystemWatcher1.Path = @"D:\Assignments_and_Notes\C#\28th Aug Assignments\MainFile\";
            //fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.Attributes | System.IO.NotifyFilters.CreationTime | 
            //                                  System.IO.NotifyFilters.DirectoryName | System.IO.NotifyFilters.FileName | 
            //                                  System.IO.NotifyFilters.LastAccess | System.IO.NotifyFilters.Size;
            //fileSystemWatcher1.Changed += OnChange;
            //fileSystemWatcher1.Renamed += OnRename;
            //fileSystemWatcher1.Deleted += OnDelete;
            //fileSystemWatcher1.Created += OnCreate;
            //fileSystemWatcher1.Error += OnError;

           // fileSystemWatcher1.EnableRaisingEvents = true;
        }
        
        protected override void OnStop()
        {
            DirectoryMonitorLog.WriteEntry("Directory Monitoring Stopped!");
        }


        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            DirectoryMonitorLog.WriteEntry("Directory Items Changed!");
            File.Copy(@"D:\Assignments_and_Notes\C#\28th Aug Assignments\MainFile\" + e.Name, @"D:\Assignments_and_Notes\C#\28th Aug Assignments\BackupFile\" + e.Name, true);
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            DirectoryMonitorLog.WriteEntry("New Directory Items Created!");
            File.Copy(@"D:\Assignments_and_Notes\C#\28th Aug Assignments\MainFile\"+e.Name, @"D:\Assignments_and_Notes\C#\28th Aug Assignments\BackupFile\"+e.Name,true);
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            DirectoryMonitorLog.WriteEntry("Directory Items Renamed!");
            File.Copy(@"D:\Assignments_and_Notes\C#\28th Aug Assignments\MainFile\" + e.Name, @"D:\Assignments_and_Notes\C#\28th Aug Assignments\BackupFile\" + e.Name, true);
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            DirectoryMonitorLog.WriteEntry("Directory Items Deleted!");
        }
    }
}
