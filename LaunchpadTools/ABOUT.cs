using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchpadTools
{
    public partial class ABOUT : Form
    {
        public ABOUT()
        {
            InitializeComponent();
            // About Text, change when needed
            aboutText.Text = "This program controls a Tiva C M4 Cortex (TM4C123GXL & TM4C1294) microcontroller from a windows computer. This program has limited function and you MUST use accompaning code uploaded to the microcontroller to access the functions!\r\n\r\nCopyright Tekcode\r\nhttp://www.thenullptr.com";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ABOUT_Load(object sender, EventArgs e)
        {

        }

        // Link label to The Null Ptr
        private void nullPtrLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.thenullptr.com");
        }
    }
}
