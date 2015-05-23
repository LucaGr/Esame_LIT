using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Esercizio_GUI
{
    public class HDD
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        /* Costrustors */
        // Default Constructor
        public HDD()
        {
            
        }

        /* Properties */
        // Total size
        public float TotalSpace
        {
            get
            {
                if (drives[0].IsReady)
                {
                    return (float)drives[0].TotalSize;
                }
                else
                {
                    throw new IOException("Impossible read drive information!");
                }

            }
            private set { }
        }

        // Returns the percentage of Available space
        public float PercentageAvailableSpace
        {
            get
            {
                if (drives[0].IsReady)
                {
                    return ((float)drives[0].TotalFreeSpace / drives[0].TotalSize)*100;
                }
                else
                {
                    throw new IOException("Impossible read drive information!");
                }

            }
            private set { }
        }

    }
}
