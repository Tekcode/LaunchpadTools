#define M4CORTEX
#define RASPBERRYPI
#define ARDUINO

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchpadTools
{
    public partial class TM4C123GXL_Control : Form
    {
        // Create new Forms outside a method to allow it to be closed
        SerialMonitor serialForm = null; // Serial Window

        public TM4C123GXL_Control()
        {
            InitializeComponent();
            
            // Platform Array Setup
            // platform = new int[3]; LATER USE

            // Launchpad Setup
            LaunchpadTools.Instance.EnableSerial();
            platformState(true, false, false); // Only enable M4 Cortex for now

            // Menu Item Disable - Remove when features are added
            disconnectToolStripMenuItem.Enabled = false; // Disable the COM Port disconnect button by default
            undoToolStripMenuItem.Enabled = false; // Edit - Undo
            copyToolStripMenuItem.Enabled = false; // Edit - Copy
            cutToolStripMenuItem.Enabled = false; // Edit - Cut
            pasteToolStripMenuItem.Enabled = false; // Edit - Paste
            selectAllToolStripMenuItem.Enabled = false; // Edit - Select All
            ethernetToolStripMenuItem.Enabled = false; // Network - Ethernet
            bluetoothToolStripMenuItem.Enabled = false; // Network - Ethernet
            wifiToolStripMenuItem.Enabled = false; // Network - Wifi
            motorControlToolStripMenuItem.Enabled = false; // Tools - Motor Control
            lcdControlToolStripMenuItem.Enabled = false; // Tools - LCD Control
        }

        // File menu EXIT
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // File menu ABOUT
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABOUT aboutForm = new ABOUT(); // Create a new about object, then show the window
            aboutForm.Show();
        }

        // File menu COM settings
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COM_SETTINGS comForm = new COM_SETTINGS(); // Create a new com about, then show the settings
            comForm.Show();
        }

        // File menu connect to COM port
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LaunchpadTools.Instance.m4cSerialPort.IsOpen)
                LaunchpadTools.Instance.OpenPort(); // If the COM port is not already open, open it
            if (LaunchpadTools.Instance.m4cSerialPort.IsOpen)
            {
                // Disable the connect button and enable the disconnect button
                connectToolStripMenuItem.Enabled = false;
                disconnectToolStripMenuItem.Enabled = true;
                MessageBox.Show(LaunchpadTools.Instance.m4cSerialPort.PortName + " Successfully Opened");
            } else {
                MessageBox.Show("Unable to open " + LaunchpadTools.Instance.m4cSerialPort.PortName + ".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // File menu discconect COM port
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LaunchpadTools.Instance.m4cSerialPort.IsOpen)
                LaunchpadTools.Instance.ClosePort(); // If the COM port is open, close it
            if (!LaunchpadTools.Instance.m4cSerialPort.IsOpen) {
                // Enable the connect button and disable the discconect button
                connectToolStripMenuItem.Enabled = true;
                disconnectToolStripMenuItem.Enabled = false;
                MessageBox.Show(LaunchpadTools.Instance.m4cSerialPort.PortName + " Successfully Closed.");
            } else {
                MessageBox.Show("Unable to disconnect from " + LaunchpadTools.Instance.m4cSerialPort.PortName + ".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void downloadCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.thenullptr.com");
        }

        private void serialWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check is form is already open, if not open, and if so, close it
            if (serialForm == null)
            {
                // Set form states and open if the window is not open
                serialForm = new SerialMonitor();

                // Set Window State
                serialForm.MdiParent = this;
                serialForm.WindowState = FormWindowState.Maximized;
                serialForm.Show();
            }
            else if (serialForm.visible == true)
            {
                serialForm.Hide(); // Close form if the serial monitor is already open
                serialForm.visible = false;
            } else
            {
                serialForm.MdiParent = this;
                serialForm.WindowState = FormWindowState.Maximized;
                serialForm.Show();
               serialForm.visible = true;
            }
        }

        // Edit - Undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // Edit - Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // Edit - Cut
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        // Edit - Paste
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        // Edit - Select All
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // Motor Control 
        private void motorControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // LCD Control
        private void lCDControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // Network - Ethernet
        private void ethernetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // Network - Bluetooth
        private void bluetoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // Network - Wifi
        private void wifiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        // M4 Cortex Platform Select Menu
        private void m4CortexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set Menu Items
            platformState(true, false, false);
        }

        // Raspberry Pi Platform Select Menu
        private void raspberryPiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set Menu Items
            platformState(false, true, false);
        }

        // Arduino Platform Select Menu
        private void arduinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set Menu Items
            platformState(false, false, true);
        }

        // Set the status of the platoform menu items
        // Use: m4Cortex status, Raspberri Pi status, Ardinio Status (True/False)
        private void platformState(bool m4, bool pi, bool arduino) 
        {
            m4CortexToolStripMenuItem.Checked = m4;
            m4CortexToolStripMenuItem.Enabled = m4;
            raspberryPiToolStripMenuItem.Checked = pi;
            raspberryPiToolStripMenuItem.Enabled = pi;
            arduinoToolStripMenuItem.Checked = arduino;
            arduinoToolStripMenuItem.Enabled = arduino;
        }
    }
}
