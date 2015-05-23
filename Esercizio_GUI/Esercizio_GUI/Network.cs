using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Esercizio_GUI
{
    public class Network
    {
        static NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

        /*Constructor*/
        // Default constructor
        public Network()
        {

        }

        /*Properties*/
        // Get automatically bytes sent by WiFi
        public int ByteSentByWiFi
        {
            get
            {
                foreach (NetworkInterface ni in networkInterfaces)
                {
                    if (ni.Name == "Wi-Fi")
                    {
                        return (int) ni.GetIPv4Statistics().BytesSent;
                    }
                }

                return 0;
            }
        }

        // Get automatically bytes received by WiFi
        public int ByteReceivedByWiFi
        {
            get
            {
                foreach (NetworkInterface ni in networkInterfaces)
                {
                    if (ni.Name == "Wi-Fi")
                    {
                        return (int)ni.GetIPv4Statistics().BytesReceived;
                    }
                }

                return 0;
            }
        }

        // Get other source of byte sent
        public int GetSentByte(string type = "Wi-Fi")
        {
            foreach (NetworkInterface ni in networkInterfaces)
            {
                if (ni.Name == type)
                {
                    return (int)ni.GetIPv4Statistics().BytesSent;
                }
            }

            return 0;
        }

        // Get other source of byte received
        public int GetReceivedByte(string type = "Wi-Fi")
        {
            foreach (NetworkInterface ni in networkInterfaces)
            {
                if (ni.Name == type)
                {
                    return (int)ni.GetIPv4Statistics().BytesReceived;
                }
            }

            return 0;
        }
    }
}
