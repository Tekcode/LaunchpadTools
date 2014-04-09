using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchpadTools
{
    public partial class COM_SETTINGS : Form
    {
        public COM_SETTINGS()
        {
            InitializeComponent();

            // Get COM ports
            getComPorts();

            // Set Default COM port in dropdown
            comPortDropDown.SelectedValue = LaunchpadTools.Instance.m4cSerialPort.PortName;


            // Get Baud Rate
            string currentBuadRate = Convert.ToString(LaunchpadTools.Instance.m4cSerialPort.BaudRate); // Convetr baud rate to a string
            baudRateTextBox.Text = currentBuadRate; // Set Baud rate to 9600 deault
        }

        // Close Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Save the COM settings to a local file
        private void button1_Click(object sender, EventArgs e)
        {
            // Need to implement this function.. save to a local file? Is this even worth it?
            Properties.Settings.Default.Save(); // Save the settings.
            MessageBox.Show("Settings saved successfully.");
            this.Close();
        }

        // Update the Baud Rate
        private void button3_Click(object sender, EventArgs e)
        {
            // Try to convert the baud rate to an int to test for a valid argument
            int tempBaud;
            int baudRate = 0;

            bool baudNum = int.TryParse(baudRateTextBox.Text, out tempBaud);
            if (baudNum)
                baudRate = Convert.ToInt32(baudRateTextBox.Text); // Convert the baud rate to an int before passing it to the update function

            if (LaunchpadTools.Instance.m4cSerialPort.IsOpen) // If the COM port is active, the program crashes
            {
                MessageBox.Show("Unable to update COM port while connected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!baudNum){ // Check if the baud rate is a number
                MessageBox.Show("You did not enter a number for a baud rate.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (baudRate <= 0 || baudRate > 200000) { // Check for a range of baud rates
                MessageBox.Show("Invalid baud rate.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {                
                LaunchpadTools.Instance.UpdateBaudRate(baudRate);
                Properties.Settings.Default.Save(); // Save the settings.
                MessageBox.Show("Buad Rate Updated Successfully");
            }
        }

        // Update the COM Port
        private void comPortButton_Click(object sender, EventArgs e)
        {
            if (LaunchpadTools.Instance.m4cSerialPort.IsOpen) { // If the COM port is active, the program crashes
                MessageBox.Show("Unable to update COM port while connected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                LaunchpadTools.Instance.UpdatePort(comPortDropDown.Text);
                Properties.Settings.Default.Save(); // Save the settings.
                MessageBox.Show("Com Port Updated Successfully");
            }
        }

        // Available COM Port drop down list
        private void comPortDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comPortRefreshButton_Click(object sender, EventArgs e)
        {
            getComPorts();
        }

        // Get COM Ports
        private void getComPorts()
        {
            comPortDropDown.Items.Clear(); // Clear COM Ports to prevent duplicates

            // Iterator over the COM Ports to add them
            foreach (String PortName in System.IO.Ports.SerialPort.GetPortNames())
                comPortDropDown.Items.Add(PortName);
        }

    }
}
