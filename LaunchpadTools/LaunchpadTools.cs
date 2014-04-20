using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadTools
{
    public class LaunchpadTools
    {

        // Initialize Objects
        public SerialPort m4cSerialPort;
        private static LaunchpadTools instance;
        

        private LaunchpadTools() {}

        // This is a singleton class -- a very hacky method to get around having a shared object
        public static LaunchpadTools Instance
        {
            get
            {
                if (instance == null)
                    instance = new LaunchpadTools();
                return instance;
            }
        }

        // Enable the Serial Connection
        public void EnableSerial()
        {
            m4cSerialPort = new SerialPort();
            m4cSerialPort.PortName = Properties.Settings.Default.comPort; // Set COM Port via user settings
            m4cSerialPort.BaudRate = Properties.Settings.Default.baudRate; // Set Baud Rate via user settings
            m4cSerialPort.Parity = Parity.None;
            m4cSerialPort.StopBits = StopBits.One;
            m4cSerialPort.DataBits = 8;
            m4cSerialPort.Handshake = Handshake.None;
            
        }

        // Opens the COM Port
        public void OpenPort()
        {
            if (!m4cSerialPort.IsOpen)
            {
                try
                {
                    m4cSerialPort.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error opening port: {0}", ex.Message);
                    //MessageBox.Show("The current COM Port does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }

        // Closes the COM Port
        public void ClosePort()
        {
            if (m4cSerialPort.IsOpen)
                m4cSerialPort.Close(); // If the COM port is open, close it
        }

        // Updates to a new COM Port
        public void UpdatePort(string portName)
        {
            m4cSerialPort.PortName = portName; // Update the COM port locally
            Properties.Settings.Default.comPort = portName; // Update the COM port in settings
        }

        // Updates a new baud rate
        public void UpdateBaudRate(int baudRate)
        {
            m4cSerialPort.BaudRate = baudRate; // Update the baud rate
            Properties.Settings.Default.baudRate = baudRate; // Update the baud rate in settings
        }

        // Gets the connected COM Ports
        public string getPortName()
        {
            return this.m4cSerialPort.PortName;
        }

        // Sends data via serial to the connected com device. Inputs the string data from the textbox and the selected index of the data type
        public void serialTx(string serialData, int index)
        {
            /* 
             *  INDEX 0 = STRING
             *  INDEX 1 = CHAR
             *  INDEX 2 = BYTE
             */
            if (index == 0) // STRING
            {
                m4cSerialPort.Write(serialData);
            }
            else if (index == 1) // CHAR
            {
                char[] serialCharData = serialData.ToCharArray(); // Convert a string to a character array
                m4cSerialPort.Write(serialCharData, 0, serialCharData.Length);
            } else if (index == 2) // BYTE
            {
                byte[] serialByte = Encoding.ASCII.GetBytes(serialData); // Convert STRING to BYTE
                m4cSerialPort.Write(serialByte, 0, serialByte.Length);
            }
        }
    }
}
