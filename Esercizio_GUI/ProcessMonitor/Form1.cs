using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esercizio_GUI;
using System.IO;

namespace ProcessMonitor
{
    public partial class ProcessMonitor : Form
    {
        public ProcessMonitor()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Computer thisPC = new Computer();

            textDate.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            textRAM.Text = thisPC.RAM.AvailableMemory.ToString();
            textHDD.Text = thisPC.HDD.PercentageAvailableSpace.ToString() + "%";
            textCPU.Text = thisPC.CPU.ProcessorUsagePercentage.ToString() + "%";
            textByteSent.Text = thisPC.Network.ByteSentByWiFi.ToString();
            textByteReceived.Text = thisPC.Network.ByteReceivedByWiFi.ToString();
            textUptime.Text = thisPC.GetUptime();
            textRunningProcesses.Text = thisPC.RunningProcesses.ToString();
        }

        private void saveAcutalLogButton_Click(object sender, EventArgs e)
        {
            Computer thisPC = new Computer();

            textDate.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            textRAM.Text = thisPC.RAM.AvailableMemory.ToString();
            textHDD.Text = thisPC.HDD.PercentageAvailableSpace.ToString() + "%";
            textCPU.Text = thisPC.CPU.ProcessorUsagePercentage.ToString() + "%";
            textByteSent.Text = thisPC.Network.ByteSentByWiFi.ToString();
            textByteReceived.Text = thisPC.Network.ByteReceivedByWiFi.ToString();
            textUptime.Text = thisPC.GetUptime();
            textRunningProcesses.Text = thisPC.RunningProcesses.ToString();

            LogFileWriter.WriteLog(thisPC);
        }

        private void saveCurrentLogButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter newLog = File.AppendText("log.txt"))
            {
                if (!string.IsNullOrWhiteSpace(textRAM.Text) &&
                    !string.IsNullOrWhiteSpace(textCPU.Text) &&
                    !string.IsNullOrWhiteSpace(textHDD.Text) &&
                    !string.IsNullOrWhiteSpace(textByteSent.Text) &&
                    !string.IsNullOrWhiteSpace(textByteReceived.Text) &&   
                    !string.IsNullOrWhiteSpace(textUptime.Text) &&
                    !string.IsNullOrWhiteSpace(textRunningProcesses.ToString()))
                {
                    newLog.WriteLine("--------------------------");
                    newLog.Write("Log date: ");
                    newLog.WriteLine(DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString());
                    newLog.WriteLine("Free RAM space: " + textRAM.Text);
                    newLog.WriteLine("Usage of CPU: " + textCPU.Text + "%");
                    newLog.WriteLine("Free Hard Drive space percentage: " + textHDD.Text + "%");
                    newLog.WriteLine("Byte sent by Wi-Fi: " + textByteSent.Text);
                    newLog.WriteLine("Byte received by Wi-Fi: " + textByteReceived.Text);
                    newLog.WriteLine("Uptime (dd:hh:mm:ss): " + textUptime.Text);
                    newLog.WriteLine("Running Processes: " + textRunningProcesses.Text);
                    newLog.WriteLine("--------------------------");
                }
                else
                {
                    MessageBox.Show("Error: empty log. Press \"Refresh\" and then \"Save this to Log\"",
                    "Process Monitor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
