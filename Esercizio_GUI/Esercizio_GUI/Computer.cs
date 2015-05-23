using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Esercizio_GUI
{
    public class Computer
    {
        RAM thisRAM;
        HDD thisHDD;
        CPU thisProcessor;
        Network thisNetwork;
        PerformanceCounter upTime = new PerformanceCounter("System", "System Up Time");
        Process[] allProcesses = Process.GetProcesses();

        /*Constructors*/
        // Default Constructor
        public Computer()
        {
            this.thisRAM = new RAM();
            this.thisHDD = new HDD();
            this.thisProcessor = new CPU();
            this.thisNetwork = new Network();
        }

        /* Properties */
        // RO --> RAM Property
        public RAM RAM
        {
            get { return thisRAM; }
            private set { }
        }

        // RO --> HHD Property
        public HDD HDD
        {
            get { return thisHDD; }
            private set { }
        }

        // RO --> CPU Property
        public CPU CPU
        {
            get { return thisProcessor; }
            private set { }
        }

        // RO --> Network
        public Network Network
        {
            get { return thisNetwork;}
        }

        // RO --> Return number of running processes 
        public int RunningProcesses
        {
            get { return allProcesses.Length; }
            private set { }
        }

        /*Methods*/
        // GetUptime() returns the uptime in dd-hh-mm-ss format
        public string GetUptime()
        {
            StringBuilder strUptime = new StringBuilder();
            upTime.NextValue();
            TimeSpan ts = TimeSpan.FromSeconds(upTime.NextValue());

            strUptime.Append(ts.Days);
            strUptime.Append(":");
            strUptime.Append(ts.Hours);
            strUptime.Append(":");
            strUptime.Append(ts.Minutes);
            strUptime.Append(":");
            strUptime.Append(ts.Seconds);

            return strUptime.ToString();
        }
    }
}
