using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Esercizio_GUI
{
    public class CPU
    {
        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

        /* Costrustors */
        // Default Constructor
        public CPU()
        {

        }

        /*Properties*/
        // Returns the percentage of Available space
        public float ProcessorUsagePercentage
        {
            get
            {
                bool check = false;

                while (check != true)
                {
                    CounterSample cs1 = cpuCounter.NextSample();
                    System.Threading.Thread.Sleep(100);
                    CounterSample cs2 = cpuCounter.NextSample();
                    float finalCpuCounter = CounterSample.Calculate(cs1, cs2);
                    if ((float)finalCpuCounter == 0)
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                        return finalCpuCounter;
                    }
                }

                return 0;
            }
            private set { }
        }

    }
}
