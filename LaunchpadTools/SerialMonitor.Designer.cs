namespace LaunchpadTools
{
    partial class SerialMonitor
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
            this.serialCommandSendButton = new System.Windows.Forms.Button();
            this.serialCommandTextbox = new System.Windows.Forms.TextBox();
            this.serialMonitorBox = new System.Windows.Forms.GroupBox();
            this.serialRxTextbox = new System.Windows.Forms.TextBox();
            this.serialMonitorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialCommandSendButton
            // 
            this.serialCommandSendButton.Location = new System.Drawing.Point(669, 17);
            this.serialCommandSendButton.Name = "serialCommandSendButton";
            this.serialCommandSendButton.Size = new System.Drawing.Size(75, 23);
            this.serialCommandSendButton.TabIndex = 0;
            this.serialCommandSendButton.Text = "Send";
            this.serialCommandSendButton.UseVisualStyleBackColor = true;
            this.serialCommandSendButton.Click += new System.EventHandler(this.serialCommandSendButton_Click);
            // 
            // serialCommandTextbox
            // 
            this.serialCommandTextbox.Location = new System.Drawing.Point(6, 19);
            this.serialCommandTextbox.Name = "serialCommandTextbox";
            this.serialCommandTextbox.Size = new System.Drawing.Size(657, 20);
            this.serialCommandTextbox.TabIndex = 1;
            // 
            // serialMonitorBox
            // 
            this.serialMonitorBox.Controls.Add(this.serialRxTextbox);
            this.serialMonitorBox.Controls.Add(this.serialCommandTextbox);
            this.serialMonitorBox.Controls.Add(this.serialCommandSendButton);
            this.serialMonitorBox.Location = new System.Drawing.Point(12, 12);
            this.serialMonitorBox.Name = "serialMonitorBox";
            this.serialMonitorBox.Size = new System.Drawing.Size(750, 491);
            this.serialMonitorBox.TabIndex = 3;
            this.serialMonitorBox.TabStop = false;
            this.serialMonitorBox.Text = "Serial Monitor";
            // 
            // serialRxTextbox
            // 
            this.serialRxTextbox.Location = new System.Drawing.Point(6, 45);
            this.serialRxTextbox.Multiline = true;
            this.serialRxTextbox.Name = "serialRxTextbox";
            this.serialRxTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serialRxTextbox.Size = new System.Drawing.Size(738, 440);
            this.serialRxTextbox.TabIndex = 2;
            // 
            // SerialMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 512);
            this.ControlBox = false;
            this.Controls.Add(this.serialMonitorBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialMonitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Serial Monitor";
            this.TopMost = true;
            this.serialMonitorBox.ResumeLayout(false);
            this.serialMonitorBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button serialCommandSendButton;
        private System.Windows.Forms.TextBox serialCommandTextbox;
        private System.Windows.Forms.GroupBox serialMonitorBox;
        public System.Windows.Forms.TextBox serialRxTextbox;
    }
}