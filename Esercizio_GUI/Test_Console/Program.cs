using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizio_GUI;
using System.Net.NetworkInformation;
namespace Test_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer thisPC = new Computer();

            Console.WriteLine(thisPC.RAM.AvailableMemory);
            Console.WriteLine(thisPC.HDD.PercentageAvailableSpace + "%");
            Console.WriteLine(thisPC.CPU.ProcessorUsagePercentage);
            Console.WriteLine(thisPC.Network.ByteSentByWiFi);
            Console.WriteLine(thisPC.Network.GetSentByte("Teredo Tunneling Pseudo-Interface"));
            Console.WriteLine(thisPC.GetUptime());

            LogFileWriter.WriteLog(thisPC);
            
            Console.ReadKey();
        }
    }
}
