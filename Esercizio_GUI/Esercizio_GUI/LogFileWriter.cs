using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Esercizio_GUI
{
    public class LogFileWriter
    {
        public static void WriteLog(Computer PC)
        {
            using (StreamWriter newLog = File.AppendText("log.txt"))
            {
                newLog.WriteLine("--------------------------");
                newLog.Write("Log date: ");
                newLog.WriteLine(DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString());
                newLog.WriteLine("Free RAM space: " + PC.RAM.AvailableMemory);
                newLog.WriteLine("Usage of CPU: " + PC.CPU.ProcessorUsagePercentage + "%");
                newLog.WriteLine("Free Hard Drive space percentage: " + PC.HDD.PercentageAvailableSpace + "%");
                newLog.WriteLine("Byte sent by Wi-Fi: " + PC.Network.ByteSentByWiFi);
                newLog.WriteLine("Byte received by Wi-Fi: " + PC.Network.ByteReceivedByWiFi);
                newLog.WriteLine("Uptime (dd:hh:mm:ss): " + PC.GetUptime());
                newLog.WriteLine("Running Processes: " + PC.RunningProcesses);

                newLog.WriteLine("--------------------------");
            }
        }
    }
}
