﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchpadTools
{
    public partial class SerialMonitor : Form
    {
        // Set Up Buffer for Rx Serial
        private string rxBuffer;
        public bool visible = true;

        public SerialMonitor()
        {
            InitializeComponent();
            
            // Textbox color initialization
            serialRxTextbox.BackColor = Color.White;
            serialCommandTextbox.ForeColor = Color.Black;
            LaunchpadTools.Instance.m4cSerialPort.DataReceived += new SerialDataReceivedEventHandler(serialPortRead);

            // Data Type Dropdown initialization
            dataTypeDropdown.Items.Add("String");
            dataTypeDropdown.Items.Add("Char");
            dataTypeDropdown.Items.Add("Byte (Hex)");
            dataTypeDropdown.SelectedIndex = 0;

            // Set up Threading
            //    Thread SerialTxThread = new Thread(this.serialTx);
            //Thread SerialRxThread = new Thread(this.SerialRx);

            //    SerialTxThread.Start();
           // SerialRxThread.Start();
        }

        private void serialCommandSendButton_Click(object sender, EventArgs e)
        {
            // Check if serial port is open, if so send the command
            if (!LaunchpadTools.Instance.m4cSerialPort.IsOpen)
            {
                MessageBox.Show(LaunchpadTools.Instance.m4cSerialPort.PortName + " is not open. Unable to send command.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LaunchpadTools.Instance.serialTx(serialCommandTextbox.Text, dataTypeDropdown.SelectedIndex);
                serialCommandTextbox.Text = ""; // Clear the command textbox
            }         
        }

        private void serialPortRead(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rxBuffer = LaunchpadTools.Instance.m4cSerialPort.ReadExisting();
            this.Invoke(new EventHandler(serialReadToTextbox));
        }

        private void serialReadToTextbox(object sender, EventArgs e)
        {
            serialRxTextbox.AppendText(rxBuffer);
        }
    }
}
