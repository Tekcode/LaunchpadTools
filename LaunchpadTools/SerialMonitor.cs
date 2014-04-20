using System;
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
            serialDataTypeDropdown.Items.Add("String");
            serialDataTypeDropdown.Items.Add("Char");
            serialDataTypeDropdown.Items.Add("Byte (Hex)");
            serialDataTypeDropdown.SelectedIndex = Properties.Settings.Default.serialDataTypeSelection;

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
                LaunchpadTools.Instance.serialTx(serialCommandTextbox.Text, serialDataTypeDropdown.SelectedIndex);
                serialCommandTextbox.Text = ""; // Clear the command textbox
            }         
        }

        // Invoke an event on serial data received
        private void serialPortRead(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rxBuffer = LaunchpadTools.Instance.m4cSerialPort.ReadExisting();
            this.Invoke(new EventHandler(serialReadToTextbox));
        }

        // Send received data to the serial rx textbox
        private void serialReadToTextbox(object sender, EventArgs e)
        {
            serialRxTextbox.AppendText(rxBuffer);
        }

        // Save the data type to send to the COM port on click
        private void serialDataTypeSend_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.serialDataTypeSelection = serialDataTypeDropdown.SelectedIndex;
        }

        // Clears the serial received window
        private void serialRxTextboxClearButton_Click(object sender, EventArgs e)
        {
            serialRxTextbox.Text = "";
        }
    }
}
