namespace LaunchpadTools
{
    partial class COM_SETTINGS
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
            this.closeButton = new System.Windows.Forms.Button();
            this.baudRateButton = new System.Windows.Forms.Button();
            this.comPortButton = new System.Windows.Forms.Button();
            this.comPortLabel = new System.Windows.Forms.Label();
            this.bautRateLabel = new System.Windows.Forms.Label();
            this.baudRateTextBox = new System.Windows.Forms.TextBox();
            this.comPortDropDown = new System.Windows.Forms.ComboBox();
            this.comPortRefreshButton = new System.Windows.Forms.Button();
            this.comSetingsBox = new System.Windows.Forms.GroupBox();
            this.comSetingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(275, 107);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // baudRateButton
            // 
            this.baudRateButton.Location = new System.Drawing.Point(212, 53);
            this.baudRateButton.Name = "baudRateButton";
            this.baudRateButton.Size = new System.Drawing.Size(126, 23);
            this.baudRateButton.TabIndex = 2;
            this.baudRateButton.Text = "Update Baud Rate";
            this.baudRateButton.UseVisualStyleBackColor = true;
            this.baudRateButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // comPortButton
            // 
            this.comPortButton.Location = new System.Drawing.Point(212, 24);
            this.comPortButton.Name = "comPortButton";
            this.comPortButton.Size = new System.Drawing.Size(126, 23);
            this.comPortButton.TabIndex = 3;
            this.comPortButton.Text = "Update COM Port";
            this.comPortButton.UseVisualStyleBackColor = true;
            this.comPortButton.Click += new System.EventHandler(this.comPortButton_Click);
            // 
            // comPortLabel
            // 
            this.comPortLabel.AutoSize = true;
            this.comPortLabel.Location = new System.Drawing.Point(10, 32);
            this.comPortLabel.Name = "comPortLabel";
            this.comPortLabel.Size = new System.Drawing.Size(67, 13);
            this.comPortLabel.TabIndex = 4;
            this.comPortLabel.Text = "COM PORT:";
            // 
            // bautRateLabel
            // 
            this.bautRateLabel.AutoSize = true;
            this.bautRateLabel.Location = new System.Drawing.Point(5, 63);
            this.bautRateLabel.Name = "bautRateLabel";
            this.bautRateLabel.Size = new System.Drawing.Size(72, 13);
            this.bautRateLabel.TabIndex = 5;
            this.bautRateLabel.Text = "BAUD RATE:";
            // 
            // baudRateTextBox
            // 
            this.baudRateTextBox.Location = new System.Drawing.Point(83, 56);
            this.baudRateTextBox.Name = "baudRateTextBox";
            this.baudRateTextBox.Size = new System.Drawing.Size(116, 20);
            this.baudRateTextBox.TabIndex = 6;
            // 
            // comPortDropDown
            // 
            this.comPortDropDown.FormattingEnabled = true;
            this.comPortDropDown.Location = new System.Drawing.Point(83, 24);
            this.comPortDropDown.Name = "comPortDropDown";
            this.comPortDropDown.Size = new System.Drawing.Size(116, 21);
            this.comPortDropDown.TabIndex = 7;
            this.comPortDropDown.SelectedIndexChanged += new System.EventHandler(this.comPortDropDown_SelectedIndexChanged);
            // 
            // comPortRefreshButton
            // 
            this.comPortRefreshButton.Location = new System.Drawing.Point(12, 107);
            this.comPortRefreshButton.Name = "comPortRefreshButton";
            this.comPortRefreshButton.Size = new System.Drawing.Size(126, 23);
            this.comPortRefreshButton.TabIndex = 8;
            this.comPortRefreshButton.Text = "Refresh COM Ports";
            this.comPortRefreshButton.UseVisualStyleBackColor = true;
            this.comPortRefreshButton.Click += new System.EventHandler(this.comPortRefreshButton_Click);
            // 
            // comSetingsBox
            // 
            this.comSetingsBox.Controls.Add(this.comPortLabel);
            this.comSetingsBox.Controls.Add(this.comPortDropDown);
            this.comSetingsBox.Controls.Add(this.bautRateLabel);
            this.comSetingsBox.Controls.Add(this.baudRateTextBox);
            this.comSetingsBox.Controls.Add(this.comPortButton);
            this.comSetingsBox.Controls.Add(this.baudRateButton);
            this.comSetingsBox.Location = new System.Drawing.Point(12, 12);
            this.comSetingsBox.Name = "comSetingsBox";
            this.comSetingsBox.Size = new System.Drawing.Size(341, 89);
            this.comSetingsBox.TabIndex = 9;
            this.comSetingsBox.TabStop = false;
            this.comSetingsBox.Text = "COM Settings";
            // 
            // COM_SETTINGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 135);
            this.Controls.Add(this.comSetingsBox);
            this.Controls.Add(this.comPortRefreshButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "COM_SETTINGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.comSetingsBox.ResumeLayout(false);
            this.comSetingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button baudRateButton;
        private System.Windows.Forms.Button comPortButton;
        private System.Windows.Forms.Label comPortLabel;
        private System.Windows.Forms.Label bautRateLabel;
        private System.Windows.Forms.TextBox baudRateTextBox;
        private System.Windows.Forms.ComboBox comPortDropDown;
        private System.Windows.Forms.Button comPortRefreshButton;
        private System.Windows.Forms.GroupBox comSetingsBox;
    }
}