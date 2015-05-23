using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Esercizio_GUI
{
    public class RAM
    {
        PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        
        /*Constructors*/
        // Default RAM
        public RAM()
        {
            this.ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        /*Properties*/
        // RAM available
        public int AvailableMemory
        {
            get { return (int) ramCounter.RawValue; }
            private set { }
        }
    }
}
