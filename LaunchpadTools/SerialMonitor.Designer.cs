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
            this.serialCommandBox = new System.Windows.Forms.GroupBox();
            this.serialDataTypeSend = new System.Windows.Forms.Button();
            this.dataTransferType = new System.Windows.Forms.Label();
            this.serialDataTypeDropdown = new System.Windows.Forms.ComboBox();
            this.serialRxTextbox = new System.Windows.Forms.TextBox();
            this.serialMonitorBox = new System.Windows.Forms.GroupBox();
            this.serialRxTextboxClearButton = new System.Windows.Forms.Button();
            this.serialCommandBox.SuspendLayout();
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
            // serialCommandBox
            // 
            this.serialCommandBox.Controls.Add(this.serialDataTypeSend);
            this.serialCommandBox.Controls.Add(this.dataTransferType);
            this.serialCommandBox.Controls.Add(this.serialDataTypeDropdown);
            this.serialCommandBox.Controls.Add(this.serialCommandTextbox);
            this.serialCommandBox.Controls.Add(this.serialCommandSendButton);
            this.serialCommandBox.Location = new System.Drawing.Point(12, 12);
            this.serialCommandBox.Name = "serialCommandBox";
            this.serialCommandBox.Size = new System.Drawing.Size(750, 72);
            this.serialCommandBox.TabIndex = 3;
            this.serialCommandBox.TabStop = false;
            this.serialCommandBox.Text = "Serial Command";
            // 
            // serialDataTypeSend
            // 
            this.serialDataTypeSend.Location = new System.Drawing.Point(233, 43);
            this.serialDataTypeSend.Name = "serialDataTypeSend";
            this.serialDataTypeSend.Size = new System.Drawing.Size(88, 23);
            this.serialDataTypeSend.TabIndex = 5;
            this.serialDataTypeSend.Text = "Save Setting";
            this.serialDataTypeSend.UseVisualStyleBackColor = true;
            this.serialDataTypeSend.Click += new System.EventHandler(this.serialDataTypeSend_Click);
            // 
            // dataTransferType
            // 
            this.dataTransferType.AutoSize = true;
            this.dataTransferType.Location = new System.Drawing.Point(6, 48);
            this.dataTransferType.Name = "dataTransferType";
            this.dataTransferType.Size = new System.Drawing.Size(102, 13);
            this.dataTransferType.TabIndex = 4;
            this.dataTransferType.Text = "Data Transfer Type:";
            // 
            // serialDataTypeDropdown
            // 
            this.serialDataTypeDropdown.FormattingEnabled = true;
            this.serialDataTypeDropdown.Location = new System.Drawing.Point(114, 45);
            this.serialDataTypeDropdown.Name = "serialDataTypeDropdown";
            this.serialDataTypeDropdown.Size = new System.Drawing.Size(113, 21);
            this.serialDataTypeDropdown.TabIndex = 3;
            // 
            // serialRxTextbox
            // 
            this.serialRxTextbox.Location = new System.Drawing.Point(6, 19);
            this.serialRxTextbox.Multiline = true;
            this.serialRxTextbox.Name = "serialRxTextbox";
            this.serialRxTextbox.ReadOnly = true;
            this.serialRxTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serialRxTextbox.Size = new System.Drawing.Size(738, 356);
            this.serialRxTextbox.TabIndex = 2;
            // 
            // serialMonitorBox
            // 
            this.serialMonitorBox.Controls.Add(this.serialRxTextboxClearButton);
            this.serialMonitorBox.Controls.Add(this.serialRxTextbox);
            this.serialMonitorBox.Location = new System.Drawing.Point(12, 90);
            this.serialMonitorBox.Name = "serialMonitorBox";
            this.serialMonitorBox.Size = new System.Drawing.Size(750, 410);
            this.serialMonitorBox.TabIndex = 4;
            this.serialMonitorBox.TabStop = false;
            this.serialMonitorBox.Text = "Serial Monitor";
            // 
            // serialRxTextboxClearButton
            // 
            this.serialRxTextboxClearButton.Location = new System.Drawing.Point(669, 381);
            this.serialRxTextboxClearButton.Name = "serialRxTextboxClearButton";
            this.serialRxTextboxClearButton.Size = new System.Drawing.Size(75, 23);
            this.serialRxTextboxClearButton.TabIndex = 3;
            this.serialRxTextboxClearButton.Text = "Clear";
            this.serialRxTextboxClearButton.UseVisualStyleBackColor = true;
            this.serialRxTextboxClearButton.Click += new System.EventHandler(this.serialRxTextboxClearButton_Click);
            // 
            // SerialMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 512);
            this.ControlBox = false;
            this.Controls.Add(this.serialMonitorBox);
            this.Controls.Add(this.serialCommandBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialMonitor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Serial Monitor";
            this.TopMost = true;
            this.serialCommandBox.ResumeLayout(false);
            this.serialCommandBox.PerformLayout();
            this.serialMonitorBox.ResumeLayout(false);
            this.serialMonitorBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button serialCommandSendButton;
        private System.Windows.Forms.TextBox serialCommandTextbox;
        private System.Windows.Forms.GroupBox serialCommandBox;
        public System.Windows.Forms.TextBox serialRxTextbox;
        private System.Windows.Forms.Label dataTransferType;
        private System.Windows.Forms.ComboBox serialDataTypeDropdown;
        private System.Windows.Forms.GroupBox serialMonitorBox;
        private System.Windows.Forms.Button serialDataTypeSend;
        private System.Windows.Forms.Button serialRxTextboxClearButton;
    }
}