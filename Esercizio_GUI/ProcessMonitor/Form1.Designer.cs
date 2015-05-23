namespace ProcessMonitor
{
    partial class ProcessMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessMonitor));
            this.freeRAMLabel = new System.Windows.Forms.Label();
            this.CPUUsageLabel = new System.Windows.Forms.Label();
            this.FreeHDDLabel = new System.Windows.Forms.Label();
            this.byteSentLabel = new System.Windows.Forms.Label();
            this.byteReceivedLabel = new System.Windows.Forms.Label();
            this.uptimeLabel = new System.Windows.Forms.Label();
            this.runningProcessesLabel = new System.Windows.Forms.Label();
            this.textRAM = new System.Windows.Forms.TextBox();
            this.textHDD = new System.Windows.Forms.TextBox();
            this.textCPU = new System.Windows.Forms.TextBox();
            this.textByteReceived = new System.Windows.Forms.TextBox();
            this.textUptime = new System.Windows.Forms.TextBox();
            this.textByteSent = new System.Windows.Forms.TextBox();
            this.textRunningProcesses = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.saveAcutalLogButton = new System.Windows.Forms.Button();
            this.saveCurrentLogButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.textDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // freeRAMLabel
            // 
            this.freeRAMLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.freeRAMLabel.AutoSize = true;
            this.freeRAMLabel.Location = new System.Drawing.Point(26, 86);
            this.freeRAMLabel.Name = "freeRAMLabel";
            this.freeRAMLabel.Size = new System.Drawing.Size(90, 13);
            this.freeRAMLabel.TabIndex = 0;
            this.freeRAMLabel.Text = "Free RAM space:";
            // 
            // CPUUsageLabel
            // 
            this.CPUUsageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CPUUsageLabel.AutoSize = true;
            this.CPUUsageLabel.Location = new System.Drawing.Point(26, 116);
            this.CPUUsageLabel.Name = "CPUUsageLabel";
            this.CPUUsageLabel.Size = new System.Drawing.Size(78, 13);
            this.CPUUsageLabel.TabIndex = 1;
            this.CPUUsageLabel.Text = "Usage of CPU:";
            // 
            // FreeHDDLabel
            // 
            this.FreeHDDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FreeHDDLabel.AutoSize = true;
            this.FreeHDDLabel.Location = new System.Drawing.Point(26, 146);
            this.FreeHDDLabel.Name = "FreeHDDLabel";
            this.FreeHDDLabel.Size = new System.Drawing.Size(174, 13);
            this.FreeHDDLabel.TabIndex = 2;
            this.FreeHDDLabel.Text = "Free Hard Drive space percentage:";
            // 
            // byteSentLabel
            // 
            this.byteSentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.byteSentLabel.AutoSize = true;
            this.byteSentLabel.Location = new System.Drawing.Point(26, 176);
            this.byteSentLabel.Name = "byteSentLabel";
            this.byteSentLabel.Size = new System.Drawing.Size(95, 13);
            this.byteSentLabel.TabIndex = 3;
            this.byteSentLabel.Text = "Byte sent by Wi-Fi:";
            // 
            // byteReceivedLabel
            // 
            this.byteReceivedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.byteReceivedLabel.AutoSize = true;
            this.byteReceivedLabel.Location = new System.Drawing.Point(26, 206);
            this.byteReceivedLabel.Name = "byteReceivedLabel";
            this.byteReceivedLabel.Size = new System.Drawing.Size(116, 13);
            this.byteReceivedLabel.TabIndex = 4;
            this.byteReceivedLabel.Text = "Byte received by Wi-Fi:";
            // 
            // uptimeLabel
            // 
            this.uptimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uptimeLabel.AutoSize = true;
            this.uptimeLabel.Location = new System.Drawing.Point(26, 236);
            this.uptimeLabel.Name = "uptimeLabel";
            this.uptimeLabel.Size = new System.Drawing.Size(111, 13);
            this.uptimeLabel.TabIndex = 5;
            this.uptimeLabel.Text = "Uptime (dd:hh:mm:ss):";
            // 
            // runningProcessesLabel
            // 
            this.runningProcessesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.runningProcessesLabel.AutoSize = true;
            this.runningProcessesLabel.Location = new System.Drawing.Point(26, 266);
            this.runningProcessesLabel.Name = "runningProcessesLabel";
            this.runningProcessesLabel.Size = new System.Drawing.Size(102, 13);
            this.runningProcessesLabel.TabIndex = 6;
            this.runningProcessesLabel.Text = "Running Processes:";
            // 
            // textRAM
            // 
            this.textRAM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textRAM.Enabled = false;
            this.textRAM.Location = new System.Drawing.Point(218, 83);
            this.textRAM.Name = "textRAM";
            this.textRAM.Size = new System.Drawing.Size(169, 20);
            this.textRAM.TabIndex = 7;
            // 
            // textHDD
            // 
            this.textHDD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textHDD.Enabled = false;
            this.textHDD.Location = new System.Drawing.Point(218, 143);
            this.textHDD.Name = "textHDD";
            this.textHDD.Size = new System.Drawing.Size(169, 20);
            this.textHDD.TabIndex = 8;
            // 
            // textCPU
            // 
            this.textCPU.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textCPU.Enabled = false;
            this.textCPU.Location = new System.Drawing.Point(218, 113);
            this.textCPU.Name = "textCPU";
            this.textCPU.Size = new System.Drawing.Size(169, 20);
            this.textCPU.TabIndex = 9;
            // 
            // textByteReceived
            // 
            this.textByteReceived.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textByteReceived.Enabled = false;
            this.textByteReceived.Location = new System.Drawing.Point(218, 203);
            this.textByteReceived.Name = "textByteReceived";
            this.textByteReceived.Size = new System.Drawing.Size(169, 20);
            this.textByteReceived.TabIndex = 12;
            // 
            // textUptime
            // 
            this.textUptime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textUptime.Enabled = false;
            this.textUptime.Location = new System.Drawing.Point(218, 233);
            this.textUptime.Name = "textUptime";
            this.textUptime.Size = new System.Drawing.Size(169, 20);
            this.textUptime.TabIndex = 11;
            // 
            // textByteSent
            // 
            this.textByteSent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textByteSent.Enabled = false;
            this.textByteSent.Location = new System.Drawing.Point(218, 173);
            this.textByteSent.Name = "textByteSent";
            this.textByteSent.Size = new System.Drawing.Size(169, 20);
            this.textByteSent.TabIndex = 10;
            // 
            // textRunningProcesses
            // 
            this.textRunningProcesses.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textRunningProcesses.Enabled = false;
            this.textRunningProcesses.Location = new System.Drawing.Point(218, 263);
            this.textRunningProcesses.Name = "textRunningProcesses";
            this.textRunningProcesses.Size = new System.Drawing.Size(169, 20);
            this.textRunningProcesses.TabIndex = 13;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(312, 305);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // saveAcutalLogButton
            // 
            this.saveAcutalLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAcutalLogButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveAcutalLogButton.Location = new System.Drawing.Point(169, 305);
            this.saveAcutalLogButton.Name = "saveAcutalLogButton";
            this.saveAcutalLogButton.Size = new System.Drawing.Size(131, 23);
            this.saveAcutalLogButton.TabIndex = 15;
            this.saveAcutalLogButton.Text = "Save Current to Log";
            this.saveAcutalLogButton.UseVisualStyleBackColor = true;
            this.saveAcutalLogButton.Click += new System.EventHandler(this.saveAcutalLogButton_Click);
            // 
            // saveCurrentLogButton
            // 
            this.saveCurrentLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveCurrentLogButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveCurrentLogButton.Location = new System.Drawing.Point(35, 305);
            this.saveCurrentLogButton.Name = "saveCurrentLogButton";
            this.saveCurrentLogButton.Size = new System.Drawing.Size(122, 23);
            this.saveCurrentLogButton.TabIndex = 16;
            this.saveCurrentLogButton.Text = "Save this to Log";
            this.saveCurrentLogButton.UseVisualStyleBackColor = true;
            this.saveCurrentLogButton.Click += new System.EventHandler(this.saveCurrentLogButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(26, 46);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 17;
            this.dateLabel.Text = "Date:";
            // 
            // textDate
            // 
            this.textDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textDate.Enabled = false;
            this.textDate.Location = new System.Drawing.Point(65, 43);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(322, 20);
            this.textDate.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Process Monitor";
            // 
            // ProcessMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 340);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.saveCurrentLogButton);
            this.Controls.Add(this.saveAcutalLogButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.textRunningProcesses);
            this.Controls.Add(this.textByteReceived);
            this.Controls.Add(this.textUptime);
            this.Controls.Add(this.textByteSent);
            this.Controls.Add(this.textCPU);
            this.Controls.Add(this.textHDD);
            this.Controls.Add(this.textRAM);
            this.Controls.Add(this.runningProcessesLabel);
            this.Controls.Add(this.uptimeLabel);
            this.Controls.Add(this.byteReceivedLabel);
            this.Controls.Add(this.byteSentLabel);
            this.Controls.Add(this.FreeHDDLabel);
            this.Controls.Add(this.CPUUsageLabel);
            this.Controls.Add(this.freeRAMLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(417, 379);
            this.MinimumSize = new System.Drawing.Size(417, 379);
            this.Name = "ProcessMonitor";
            this.Text = "Process Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label freeRAMLabel;
        private System.Windows.Forms.Label CPUUsageLabel;
        private System.Windows.Forms.Label FreeHDDLabel;
        private System.Windows.Forms.Label byteSentLabel;
        private System.Windows.Forms.Label byteReceivedLabel;
        private System.Windows.Forms.Label uptimeLabel;
        private System.Windows.Forms.Label runningProcessesLabel;
        private System.Windows.Forms.TextBox textRAM;
        private System.Windows.Forms.TextBox textHDD;
        private System.Windows.Forms.TextBox textCPU;
        private System.Windows.Forms.TextBox textByteReceived;
        private System.Windows.Forms.TextBox textUptime;
        private System.Windows.Forms.TextBox textByteSent;
        private System.Windows.Forms.TextBox textRunningProcesses;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button saveAcutalLogButton;
        private System.Windows.Forms.Button saveCurrentLogButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.Label label2;
    }
}

